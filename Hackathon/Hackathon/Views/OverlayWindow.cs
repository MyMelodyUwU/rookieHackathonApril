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
<<<<<<< HEAD:Hackathon/Hackathon/OverlayWindow.cs
        public static OverlayWindow instance;
        public static TaskTraySettings taskTrayInstance;

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

=======
>>>>>>> steveKabir:Hackathon/Hackathon/Views/OverlayWindow.cs
        public OverlayWindow()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            NativeImport.SetWindowLong(this.Handle, NativeImport.WindowsStyleModifiers.GWL_EXSTYLE,
             (IntPtr)(NativeImport.GetWindowLong(this.Handle, NativeImport.WindowsStyleModifiers.GWL_EXSTYLE) | NativeImport.WindowsStyleModifiers.WS_EX_LAYERED | NativeImport.WindowsStyleModifiers.WS_EX_TRANSPARENT));
            // set transparency to 50% (128)
 
            NativeImport.SetLayeredWindowAttributes(this.Handle, NativeImport.WindowsStyleModifiers.LWA_COLORKEY, 1, NativeImport.WindowsStyleModifiers.LWA_ALPHA);

            this.BackColor = Color.FromArgb(1,2,3);
        }

        private int m_timerSize = 100;
        public int timerSize
        {
            get
            {
                return m_timerSize;
            }
            set
            {
                if (m_timerSize != value)
                    m_timerSize = value;
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
                    m_timerPadding = value;
            }
        }

        List<Task> tasks = new List<Task>();
        Task currTask = null;
        int currTaskIndex = 0;

        float timerMinutes = 1;
        float timerSeconds = 30;

        float currMin = 1;
        float currSec = 30;

        public void NextTask()
        {
            if (currTaskIndex < tasks.Count)
            {
                currTask = tasks[currTaskIndex];
                timerMinutes = currTask.timerMinutes;
                timerSeconds = currTask.timerSeconds;

                currMin = timerMinutes;
                currSec = timerSeconds;

                currTaskIndex++;
            }
            else
            {
                Console.WriteLine("No tasks next");
                currTask = new Task(0, 0, Color.LawnGreen, Color.White, "TASKS COMPLETE!", "", 14);
                timerMinutes = currTask.timerMinutes;
                timerSeconds = currTask.timerSeconds;
                currMin = timerMinutes;
                currSec = timerSeconds;
            }
        }

        private void SecondsTimer_Tick(object sender, EventArgs e)
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
                this.Invalidate();
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

<<<<<<< HEAD:Hackathon/Hackathon/OverlayWindow.cs
                Timer.DrawCircularTimer(e,
                    new Vector2(Width - m_timerPadding, Height - m_timerPadding),
                    m_timerSize,
=======
                RenderTimer.DrawCircularTimer(e,
                    new Vector2(Width - timerPadding, Height- timerPadding),
                    timerSize,
>>>>>>> steveKabir:Hackathon/Hackathon/Views/OverlayWindow.cs
                    timerMainText,
                    currTask.timerColor, 
                    currTask.timerBGColor,
                    percent,
                    currTask.timerSubText,
                    currTask.timerWidth,
                    currTask.textFontSize,
                    currTask.subTextFontSize
                );
            }
        }

        private void OverlayWindow_Load(object sender, EventArgs e)
        {
            instance = this;
            TaskTraySettings taskTraySettings = new TaskTraySettings();
            taskTrayInstance = taskTraySettings;

            LoadTasks();
            NextTask();
        }

        void LoadTasks()
        { 
            tasks.Add(new Task(0, 3, Color.Orange,Color.White,null, "BREAK", 16, 8, 10));
            tasks.Add(new Task(0, 3, Color.LawnGreen,Color.White,null, "WORK", 16, 8, 10));
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            //Open up settings panel
            taskTrayInstance.Show();
            taskTrayInstance.StartPosition = FormStartPosition.Manual;
            taskTrayInstance.Location = new Point(Width - taskTrayInstance.Size.Width, Height - taskTrayInstance.Size.Height);
            taskTrayInstance.TopMost = true;
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

        public Task(int timerMinutes, int timerSeconds, Color timerColor,Color timerBGColor,string timerMainText=null, string timerSubText ="", int textFontSize=16, int subTextFontSize=10,int timerWidth=10)
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
