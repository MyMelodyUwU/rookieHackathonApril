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

        private void deleteTaskBTN_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndex >= 0)
            {
                int taskIndex = tasksListBox.SelectedIndex;
                Program.overlayWindowInstance.RemoveTask(taskIndex);
                RefreshList();
            }
        }

        private void editTaskButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndex >= 0)
            {
                int taskIndex = tasksListBox.SelectedIndex;
                Task selectedTask = Program.overlayWindowInstance.tasks[taskIndex];
                Program.newTaskInstance.SetData(selectedTask.timerSubText, selectedTask.timerMinutes, selectedTask.timerSeconds, selectedTask.timerColor);
            }
        }

        public void RefreshList()
        {
            List<string> tasksList = new List<string>();
            foreach (Task task in Program.overlayWindowInstance.tasks)
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

        private void startTaskListBTN_Click(object sender, EventArgs e)
        {
            Program.overlayWindowInstance.StartTaskList();
        }

        private void stopTaskListBTN_Click(object sender, EventArgs e)
        {
            Program.overlayWindowInstance.StopTaskList();
        }

        private void restartTaskList_Click(object sender, EventArgs e)
        {
            Program.overlayWindowInstance.RestartList();
        }

        private void tasksListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Pen rectPen = new Pen(Program.overlayWindowInstance.tasks[tasksListBox.SelectedIndex].timerColor,10);
                e.Graphics.DrawRectangle(rectPen, e.Bounds);
            }
        }
    }
}
