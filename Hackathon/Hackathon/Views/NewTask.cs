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
        }

        public void SetData(string taskName,int taskMinutes, int taskSeconds,  Color taskColor)
        {
            taskNameInput.Text = taskName;
            minutesSelect.Value = taskMinutes;
            secondsSelect.Value = taskSeconds;
            timerColorPicker.Color = taskColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timerColorPicker.ShowDialog();
            pictureBox1.BackColor = timerColorPicker.Color;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            string taskName = taskNameInput.Text;
            int minuteDuration = (int)minutesSelect.Value;
            int secondsDuration = (int)secondsSelect.Value;
            Color timerColor = timerColorPicker.Color;

            Program.overlayWindowInstance.AddNewTask(minuteDuration, secondsDuration, timerColor, Color.White, null, taskName);
            Program.tasktraySettingsInstance.RefreshList();
            this.Close();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
