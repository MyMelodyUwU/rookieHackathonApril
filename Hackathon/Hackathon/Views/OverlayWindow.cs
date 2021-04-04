using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using Hackathon.Tools;

namespace Hackathon.Views
{
    public partial class OverlayWindow : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        public const int GWL_EXSTYLE = -20;

        public const int WS_EX_LAYERED = 0x80000;

        public const int WS_EX_TRANSPARENT = 0x20;

        public const int LWA_ALPHA = 0x1;

        public const int LWA_COLORKEY = 0x030201;

        public OverlayWindow()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            NativeImport.SetWindowLong(this.Handle, NativeImport.WindowsStyleModifiers.GWL_EXSTYLE,
             (IntPtr)(NativeImport.GetWindowLong(this.Handle, NativeImport.WindowsStyleModifiers.GWL_EXSTYLE) | NativeImport.WindowsStyleModifiers.WS_EX_LAYERED | NativeImport.WindowsStyleModifiers.WS_EX_TRANSPARENT));
            NativeImport.SetLayeredWindowAttributes(this.Handle, NativeImport.WindowsStyleModifiers.LWA_COLORKEY, 1, NativeImport.WindowsStyleModifiers.LWA_ALPHA);

            this.BackColor = Color.FromArgb(1,2,3);
        }

        private int m_timerSize = 125;
        public int timerSize
        {
            get
            {
                return m_timerSize;
            }
            set
            {
                if (m_timerSize != value)
                { 
                    m_timerSize = value;
                    this.Refresh();
                }
            }
        }

        private int m_timerPadding = 50;
        public int timerPadding
        {
            get
            {
                return m_timerPadding;
            }
            set
            {
                if (m_timerPadding != value)
                {
                    m_timerPadding = value;
                    this.Refresh();
                }
            }
        }

        private int m_arcWidth = 10;
        public int arcWidth
        {
            get
            {
                return m_arcWidth;
            }
            set
            {
                if(m_arcWidth != value)
                {
                    m_arcWidth = value;
                    this.Refresh();
                }
            }
        }

        List<Task> currTasks = new List<Task>();
        
        List<Task> m_tasks = new List<Task>();
        public List<Task> tasks
        {
            get
            {
                return currTasks;
            }
        }
        Task completedTask = new Task(0, 0, Color.LawnGreen, Color.White, "TASKS COMPLETE!", "", 14);

        Task currTask = null;
        int currTaskIndex = 0;
        bool timerRunning = false;

        float timerMinutes = 1;
        float timerSeconds = 30;

        float currMin = 1;
        float currSec = 30;

        public void NextTask()
        {
            if (currTaskIndex < m_tasks.Count)
            {
                currTask = m_tasks[currTaskIndex];
                timerMinutes = currTask.timerMinutes;
                timerSeconds = currTask.timerSeconds;

                currMin = timerMinutes;
                currSec = timerSeconds;

                currTaskIndex++;
            }
            else
            {
                Console.WriteLine("No tasks next");
                currTask = completedTask;
                timerMinutes = currTask.timerMinutes;
                timerSeconds = currTask.timerSeconds;
                currMin = timerMinutes;
                currSec = timerSeconds;
            }
        }

        private void SecondsTimer_Tick(object sender, EventArgs e)
        {
            if (timerRunning)
            {
                if (currTask != null)
                {
                    currSec--;

                    if (currMin <= 0 && currSec <= 0)
                        NextTask();

                    if (currSec <= 0)
                    {
                        currSec = 59;
                        currMin--;
                    }

                    this.Refresh();
                }
            }
        }

        private void OverlayWindow_Paint(object sender, PaintEventArgs e)
        {
            if (currTask != null)
            {
                float percent = 100 - ((currSec + (currMin * 60)) / (timerSeconds + (timerMinutes * 60))) * 100;

                TimeSpan timeLeft = new TimeSpan(0, (int)currMin, (int)currSec);

                string timerMainText = currTask.timerMainText;

                if(timerMainText == null)
                    timerMainText = timeLeft.ToString(@"mm\:ss");

                Tools.RenderTimer.DrawCircularTimer(e,
                    new Vector2(Width - m_timerPadding, Height- m_timerPadding),
                    timerSize,
                    timerMainText,
                    currTask.timerColor, 
                    currTask.timerBGColor,
                    percent,
                    currTask.timerSubText,
                    m_arcWidth,
                    currTask.textFontSize,
                    currTask.subTextFontSize
                );
            }
        }

        private void OverlayWindow_Load(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;

            NextTask();
        }

        public void LoadTaskList(List<Task> tasks)
        {
            timerRunning = false;
            currTasks.Clear();

            foreach(Task task in tasks)
            {
                currTasks.Add(task);
            }
            m_tasks = currTasks;

            NextTask();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            //Open up settings panel
            Program.tasktraySettingsInstance.Show();
            Program.tasktraySettingsInstance.StartPosition = FormStartPosition.Manual;
            Program.tasktraySettingsInstance.Location = new Point(Width - Program.tasktraySettingsInstance.Size.Width, Height - Program.tasktraySettingsInstance.Size.Height);
            Program.tasktraySettingsInstance.TopMost = true;
        }

        public void AddNewTask(int timerMinutes, int timerSeconds, Color timerColor, Color timerBGColor, string timerMainText = null, string timerSubText = "", int textFontSize = 32, int subTextFontSize = 24, int timerWidth = 10)
        {
            Task newTask = new Task(timerMinutes,
                timerSeconds,
                timerColor,
                timerBGColor,
                timerMainText,
                timerSubText,
                textFontSize,
                subTextFontSize,
                timerWidth
            );
            currTasks.Add(newTask);
           // m_tasks.Add(newTask);
        }

        public void EditTask(int editTaskIndex, int timerMinutes, int timerSeconds, Color timerColor, Color timerBGColor, string timerMainText = null, string timerSubText = "", int textFontSize = 32, int subTextFontSize = 24, int timerWidth = 10)
        {
            Task newTask = new Task(timerMinutes,
               timerSeconds,
               timerColor,
               timerBGColor,
               timerMainText,
               timerSubText,
               textFontSize,
               subTextFontSize,
               timerWidth
            );
            currTasks[editTaskIndex] = newTask;
           // m_tasks[editTaskIndex] = newTask;
        }

        public void RemoveTask(int taskIndex)
        {
            if (taskIndex < m_tasks.Count)
            {
                currTasks.RemoveAt(taskIndex);
               // m_tasks.RemoveAt(taskIndex);
            }
        }

        public void SetTaskList(List<Task> newList)
        {
            currTasks = newList;
            m_tasks = newList;
        }

        public void StartTaskList()
        {
            timerRunning = true;
        }
        public void StopTaskList()
        {
            timerRunning = false;
        }
        public void RestartList()
        {
            currTaskIndex = 0;
            m_tasks = currTasks;

            timerRunning = true;

            NextTask();
            this.Refresh();
        }

        private void OverlayWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = false;
            notifyIcon.Icon = null;
            notifyIcon.Dispose();
            notifyIcon = null;

            Program.newTaskInstance.Close();
            Program.tasktrayIconSettingsInstance.Close();
            Program.tasktraySettingsInstance.Close();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Program.tasktrayIconSettingsInstance.Location = new Point(MousePosition.X, MousePosition.Y - Program.tasktrayIconSettingsInstance.Height);
                Program.tasktrayIconSettingsInstance.Show();
            }
        }
    }

    public class Task
    {
        public int timerMinutes;
        public int timerSeconds;

        public string timerMainText;
        public string timerSubText;
        public Color timerColor;
        public Color timerBGColor;

        public int textFontSize;
        public int subTextFontSize;

        public int timerWidth;

        public Task(int timerMinutes, int timerSeconds, Color timerColor,Color timerBGColor,string timerMainText=null, string timerSubText ="", int textFontSize=32, int subTextFontSize=24,int timerWidth=10)
        {
            this.timerMinutes = timerMinutes;
            this.timerSeconds = timerSeconds;
            this.timerMainText = timerMainText;
            this.timerSubText = timerSubText;
            this.timerColor = timerColor;
            this.timerBGColor = timerBGColor;
            this.textFontSize = textFontSize;
            this.subTextFontSize = subTextFontSize;
            this.timerWidth = timerWidth;
        }
    }
}
