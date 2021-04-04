using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void padding_TB_Scroll(object sender, EventArgs e)
        {
            Program.overlayWindowInstance.timerPadding = padding_TB.Value;
        }

        private void widthTB_Scroll(object sender, EventArgs e)
        {
            Program.overlayWindowInstance.arcWidth = widthTB.Value;
        }

        private void createTaskBTN_Click(object sender, EventArgs e)
        {
            Program.newTaskInstance.ClearData();
            Program.newTaskInstance.editing = false;
            Program.newTaskInstance.editIndex = -1;
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

                Program.newTaskInstance.ClearData();
                Program.newTaskInstance.editing = true;
                Program.newTaskInstance.editIndex = taskIndex;
                Program.newTaskInstance.SetData(selectedTask.timerSubText, selectedTask.timerMinutes, selectedTask.timerSeconds, selectedTask.timerColor);
                Program.newTaskInstance.Show();
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

        private void TaskTraySettings_Load(object sender, EventArgs e)
        {
            timerSizeTB.Value = Program.overlayWindowInstance.timerSize;
            padding_TB.Value = Program.overlayWindowInstance.timerPadding;
            widthTB.Value = Program.overlayWindowInstance.arcWidth;

            RefreshList();
        }

        private void LoadTaskListBTN_Click(object sender, EventArgs e)
        {
            loadFileDialog.Filter = "JSON files (*.json)|*.json";

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = loadFileDialog.FileName;

                string json = File.ReadAllText(filePath);
                List<Task> loadedTaskList = JsonConvert.DeserializeObject<List<Task>>(json);

                Program.overlayWindowInstance.LoadTaskList(loadedTaskList);

                RefreshList();
            }
        }

        private void SaveTaskListBTN_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JSON files (*.json)|*.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = saveFileDialog.FileName;

                File.WriteAllText(filePath, JsonConvert.SerializeObject(Program.overlayWindowInstance.tasks));
            }
        }

        private void TaskTraySettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
