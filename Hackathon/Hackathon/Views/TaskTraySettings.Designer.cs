
namespace Hackathon.Views
{
    partial class TaskTraySettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskTraySettings));
            this.timerSizeTB = new System.Windows.Forms.TrackBar();
            this.timerSizeLBL = new System.Windows.Forms.Label();
            this.createTaskBTN = new System.Windows.Forms.Button();
            this.tasksListBox = new System.Windows.Forms.ListBox();
            this.deleteTaskBTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LoadTaskListBTN = new System.Windows.Forms.Button();
            this.startTaskListBTN = new System.Windows.Forms.Button();
            this.stopTaskListBTN = new System.Windows.Forms.Button();
            this.restartTaskList = new System.Windows.Forms.Button();
            this.SaveTaskListBTN = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timerSizeTB)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSizeTB
            // 
            this.timerSizeTB.LargeChange = 50;
            this.timerSizeTB.Location = new System.Drawing.Point(12, 66);
            this.timerSizeTB.Maximum = 200;
            this.timerSizeTB.Minimum = 50;
            this.timerSizeTB.Name = "timerSizeTB";
            this.timerSizeTB.Size = new System.Drawing.Size(337, 45);
            this.timerSizeTB.SmallChange = 10;
            this.timerSizeTB.TabIndex = 0;
            this.timerSizeTB.TickFrequency = 20;
            this.timerSizeTB.Value = 50;
            this.timerSizeTB.Scroll += new System.EventHandler(this.timerSizeTB_Scroll);
            // 
            // timerSizeLBL
            // 
            this.timerSizeLBL.AutoSize = true;
            this.timerSizeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerSizeLBL.Location = new System.Drawing.Point(13, 50);
            this.timerSizeLBL.Name = "timerSizeLBL";
            this.timerSizeLBL.Size = new System.Drawing.Size(54, 13);
            this.timerSizeLBL.TabIndex = 1;
            this.timerSizeLBL.Text = "Timer size";
            // 
            // createTaskBTN
            // 
            this.createTaskBTN.Location = new System.Drawing.Point(16, 145);
            this.createTaskBTN.Name = "createTaskBTN";
            this.createTaskBTN.Size = new System.Drawing.Size(75, 23);
            this.createTaskBTN.TabIndex = 2;
            this.createTaskBTN.Text = "New Task";
            this.createTaskBTN.UseVisualStyleBackColor = true;
            this.createTaskBTN.Click += new System.EventHandler(this.createTaskBTN_Click);
            // 
            // tasksListBox
            // 
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.Location = new System.Drawing.Point(16, 174);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(333, 225);
            this.tasksListBox.TabIndex = 3;
            this.tasksListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tasksListBox_DrawItem);
            // 
            // deleteTaskBTN
            // 
            this.deleteTaskBTN.Location = new System.Drawing.Point(178, 145);
            this.deleteTaskBTN.Name = "deleteTaskBTN";
            this.deleteTaskBTN.Size = new System.Drawing.Size(75, 23);
            this.deleteTaskBTN.TabIndex = 2;
            this.deleteTaskBTN.Text = "Delete Task";
            this.deleteTaskBTN.UseVisualStyleBackColor = true;
            this.deleteTaskBTN.Click += new System.EventHandler(this.deleteTaskBTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // LoadTaskListBTN
            // 
            this.LoadTaskListBTN.Location = new System.Drawing.Point(162, 117);
            this.LoadTaskListBTN.Name = "LoadTaskListBTN";
            this.LoadTaskListBTN.Size = new System.Drawing.Size(87, 21);
            this.LoadTaskListBTN.TabIndex = 5;
            this.LoadTaskListBTN.Text = "Load Task List";
            this.LoadTaskListBTN.UseVisualStyleBackColor = true;
            // 
            // startTaskListBTN
            // 
            this.startTaskListBTN.Location = new System.Drawing.Point(16, 12);
            this.startTaskListBTN.Name = "startTaskListBTN";
            this.startTaskListBTN.Size = new System.Drawing.Size(110, 35);
            this.startTaskListBTN.TabIndex = 6;
            this.startTaskListBTN.Text = "Start task list";
            this.startTaskListBTN.UseVisualStyleBackColor = true;
            this.startTaskListBTN.Click += new System.EventHandler(this.startTaskListBTN_Click);
            // 
            // stopTaskListBTN
            // 
            this.stopTaskListBTN.Location = new System.Drawing.Point(132, 12);
            this.stopTaskListBTN.Name = "stopTaskListBTN";
            this.stopTaskListBTN.Size = new System.Drawing.Size(109, 35);
            this.stopTaskListBTN.TabIndex = 6;
            this.stopTaskListBTN.Text = "Stop task list";
            this.stopTaskListBTN.UseVisualStyleBackColor = true;
            this.stopTaskListBTN.Click += new System.EventHandler(this.stopTaskListBTN_Click);
            // 
            // restartTaskList
            // 
            this.restartTaskList.Location = new System.Drawing.Point(247, 12);
            this.restartTaskList.Name = "restartTaskList";
            this.restartTaskList.Size = new System.Drawing.Size(100, 35);
            this.restartTaskList.TabIndex = 6;
            this.restartTaskList.Text = "Restart task list";
            this.restartTaskList.UseVisualStyleBackColor = true;
            this.restartTaskList.Click += new System.EventHandler(this.restartTaskList_Click);
            // 
            // SaveTaskListBTN
            // 
            this.SaveTaskListBTN.Location = new System.Drawing.Point(255, 115);
            this.SaveTaskListBTN.Name = "SaveTaskListBTN";
            this.SaveTaskListBTN.Size = new System.Drawing.Size(94, 23);
            this.SaveTaskListBTN.TabIndex = 2;
            this.SaveTaskListBTN.Text = "Save Task List";
            this.SaveTaskListBTN.UseVisualStyleBackColor = true;
            this.SaveTaskListBTN.Click += new System.EventHandler(this.deleteTaskBTN_Click);
            // 
            // editTaskButton
            // 
            this.editTaskButton.Location = new System.Drawing.Point(97, 145);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(75, 23);
            this.editTaskButton.TabIndex = 2;
            this.editTaskButton.Text = "Edit Task";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.editTaskButton_Click);
            // 
            // TaskTraySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 411);
            this.Controls.Add(this.restartTaskList);
            this.Controls.Add(this.stopTaskListBTN);
            this.Controls.Add(this.startTaskListBTN);
            this.Controls.Add(this.LoadTaskListBTN);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tasksListBox);
            this.Controls.Add(this.SaveTaskListBTN);
            this.Controls.Add(this.editTaskButton);
            this.Controls.Add(this.deleteTaskBTN);
            this.Controls.Add(this.createTaskBTN);
            this.Controls.Add(this.timerSizeLBL);
            this.Controls.Add(this.timerSizeTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskTraySettings";
            this.ShowInTaskbar = false;
            this.Text = "Hackathon Settings";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.TaskTraySettings_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.timerSizeTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar timerSizeTB;
        private System.Windows.Forms.Label timerSizeLBL;
        private System.Windows.Forms.Button createTaskBTN;
        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.Button deleteTaskBTN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button LoadTaskListBTN;
        private System.Windows.Forms.Button startTaskListBTN;
        private System.Windows.Forms.Button stopTaskListBTN;
        private System.Windows.Forms.Button restartTaskList;
        private System.Windows.Forms.Button SaveTaskListBTN;
        private System.Windows.Forms.Button editTaskButton;
    }
}