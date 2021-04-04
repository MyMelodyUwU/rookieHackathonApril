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
    public partial class TaskTraySettings : Form
    {
        public TaskTraySettings()
        {
            InitializeComponent();
        }

        private void timerSizeTB_Scroll(object sender, EventArgs e)
        {
            Program.overlayWindowInstance.timerSize = timerSizeTB.Value;
        }

        private void createTaskBTN_Click(object sender, EventArgs e)
        {
            Program.newTaskInstance.Show();
        }

        public void RefreshList()
        {
            List<string> tasksList = new List<string>();
            foreach(Task task in Program.overlayWindowInstance.tasks)
            {
                tasksList.Add($"{task.timerSubText} - {task.timerMinutes}m {task.timerSeconds}s");
            }

            tasksListBox.Items.Clear();
            tasksListBox.Items.AddRange(tasksList.ToArray());
        }

        private void TaskTraySettings_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void deleteTaskBTN_Click(object sender, EventArgs e)
        {
            if(tasksListBox.SelectedIndex >= 0)
            {
                int taskIndex = tasksListBox.SelectedIndex;
                Program.overlayWindowInstance.RemoveTask(taskIndex);
                RefreshList();
            }
        }
    }
}
