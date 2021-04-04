using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon.Views
{
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            ClearData();
        }

        public void SetData(string taskName,int taskMinutes, int taskSeconds,  Color taskColor)
        {
            taskNameInput.Text = taskName;
            minutesSelect.Value = taskMinutes;
            secondsSelect.Value = taskSeconds;
            timerColorPicker.Color = taskColor;
            pictureBox1.BackColor = taskColor;
        }

        public void ClearData()
        {
            taskNameInput.Text = "";
            minutesSelect.Value = 0;
            secondsSelect.Value = 0;
            timerColorPicker.Color = Color.LawnGreen;
            pictureBox1.BackColor = Color.LawnGreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timerColorPicker.ShowDialog();
            pictureBox1.BackColor = timerColorPicker.Color;
        }

        public bool editing = false;
        public int editIndex = -1;
        private void AddBTN_Click(object sender, EventArgs e)
        {
            string taskName = taskNameInput.Text;
            int minuteDuration = (int)minutesSelect.Value;
            int secondsDuration = (int)secondsSelect.Value;
            Color timerColor = timerColorPicker.Color;

            timerColor = timerColor == null ? Color.LawnGreen : timerColor;

            if (!string.IsNullOrEmpty(taskName) && (minuteDuration > 0 || secondsDuration > 0))
            {
                if (!editing)
                {
                    Program.overlayWindowInstance.AddNewTask(minuteDuration, secondsDuration, timerColor, Color.White, null, taskName);
                }
                else
                {
                    Program.overlayWindowInstance.EditTask(editIndex, minuteDuration, secondsDuration, timerColor, Color.White, null, taskName);
                }
                Program.tasktraySettingsInstance.RefreshList();
                this.Hide();
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NewTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
