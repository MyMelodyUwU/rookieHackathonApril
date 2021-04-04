
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
            this.LoadTaskListBTN = new System.Windows.Forms.Button();
            this.startTaskListBTN = new System.Windows.Forms.Button();
            this.stopTaskListBTN = new System.Windows.Forms.Button();
            this.restartTaskList = new System.Windows.Forms.Button();
            this.SaveTaskListBTN = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.paddingLBL = new System.Windows.Forms.Label();
            this.padding_TB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.widthTB = new System.Windows.Forms.TrackBar();
            this.darkModeCB = new System.Windows.Forms.CheckBox();
            this.clearTaskButton = new System.Windows.Forms.Button();
            this.autoDarkMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timerSizeTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padding_TB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTB)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSizeTB
            // 
            this.timerSizeTB.LargeChange = 50;
            this.timerSizeTB.Location = new System.Drawing.Point(9, 78);
            this.timerSizeTB.Maximum = 200;
            this.timerSizeTB.Minimum = 50;
            this.timerSizeTB.Name = "timerSizeTB";
            this.timerSizeTB.Size = new System.Drawing.Size(331, 45);
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
            this.timerSizeLBL.Location = new System.Drawing.Point(9, 62);
            this.timerSizeLBL.Name = "timerSizeLBL";
            this.timerSizeLBL.Size = new System.Drawing.Size(54, 13);
            this.timerSizeLBL.TabIndex = 1;
            this.timerSizeLBL.Text = "Timer size";
            // 
            // createTaskBTN
            // 
            this.createTaskBTN.Location = new System.Drawing.Point(12, 326);
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
            this.tasksListBox.Location = new System.Drawing.Point(12, 355);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(335, 225);
            this.tasksListBox.TabIndex = 3;
            this.tasksListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tasksListBox_DrawItem);
            // 
            // deleteTaskBTN
            // 
            this.deleteTaskBTN.Location = new System.Drawing.Point(262, 326);
            this.deleteTaskBTN.Name = "deleteTaskBTN";
            this.deleteTaskBTN.Size = new System.Drawing.Size(85, 23);
            this.deleteTaskBTN.TabIndex = 2;
            this.deleteTaskBTN.Text = "Delete Task";
            this.deleteTaskBTN.UseVisualStyleBackColor = true;
            this.deleteTaskBTN.Click += new System.EventHandler(this.deleteTaskBTN_Click);
            // 
            // LoadTaskListBTN
            // 
            this.LoadTaskListBTN.Location = new System.Drawing.Point(174, 297);
            this.LoadTaskListBTN.Name = "LoadTaskListBTN";
            this.LoadTaskListBTN.Size = new System.Drawing.Size(173, 23);
            this.LoadTaskListBTN.TabIndex = 5;
            this.LoadTaskListBTN.Text = "Load Task List";
            this.LoadTaskListBTN.UseVisualStyleBackColor = true;
            this.LoadTaskListBTN.Click += new System.EventHandler(this.LoadTaskListBTN_Click);
            // 
            // startTaskListBTN
            // 
            this.startTaskListBTN.Location = new System.Drawing.Point(12, 12);
            this.startTaskListBTN.Name = "startTaskListBTN";
            this.startTaskListBTN.Size = new System.Drawing.Size(107, 35);
            this.startTaskListBTN.TabIndex = 6;
            this.startTaskListBTN.Text = "Start task list";
            this.startTaskListBTN.UseVisualStyleBackColor = true;
            this.startTaskListBTN.Click += new System.EventHandler(this.startTaskListBTN_Click);
            // 
            // stopTaskListBTN
            // 
            this.stopTaskListBTN.Location = new System.Drawing.Point(125, 12);
            this.stopTaskListBTN.Name = "stopTaskListBTN";
            this.stopTaskListBTN.Size = new System.Drawing.Size(107, 35);
            this.stopTaskListBTN.TabIndex = 6;
            this.stopTaskListBTN.Text = "Stop task list";
            this.stopTaskListBTN.UseVisualStyleBackColor = true;
            this.stopTaskListBTN.Click += new System.EventHandler(this.stopTaskListBTN_Click);
            // 
            // restartTaskList
            // 
            this.restartTaskList.Location = new System.Drawing.Point(238, 12);
            this.restartTaskList.Name = "restartTaskList";
            this.restartTaskList.Size = new System.Drawing.Size(109, 35);
            this.restartTaskList.TabIndex = 6;
            this.restartTaskList.Text = "Restart task list";
            this.restartTaskList.UseVisualStyleBackColor = true;
            this.restartTaskList.Click += new System.EventHandler(this.restartTaskList_Click);
            // 
            // SaveTaskListBTN
            // 
            this.SaveTaskListBTN.Location = new System.Drawing.Point(12, 297);
            this.SaveTaskListBTN.Name = "SaveTaskListBTN";
            this.SaveTaskListBTN.Size = new System.Drawing.Size(156, 23);
            this.SaveTaskListBTN.TabIndex = 2;
            this.SaveTaskListBTN.Text = "Save Task List";
            this.SaveTaskListBTN.UseVisualStyleBackColor = true;
            this.SaveTaskListBTN.Click += new System.EventHandler(this.SaveTaskListBTN_Click);
            // 
            // editTaskButton
            // 
            this.editTaskButton.Location = new System.Drawing.Point(93, 326);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(75, 23);
            this.editTaskButton.TabIndex = 2;
            this.editTaskButton.Text = "Edit Task";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.editTaskButton_Click);
            // 
            // paddingLBL
            // 
            this.paddingLBL.AutoSize = true;
            this.paddingLBL.Location = new System.Drawing.Point(12, 130);
            this.paddingLBL.Name = "paddingLBL";
            this.paddingLBL.Size = new System.Drawing.Size(46, 13);
            this.paddingLBL.TabIndex = 7;
            this.paddingLBL.Text = "Padding";
            // 
            // padding_TB
            // 
            this.padding_TB.Location = new System.Drawing.Point(12, 146);
            this.padding_TB.Maximum = 200;
            this.padding_TB.Minimum = 50;
            this.padding_TB.Name = "padding_TB";
            this.padding_TB.Size = new System.Drawing.Size(328, 45);
            this.padding_TB.TabIndex = 8;
            this.padding_TB.TickFrequency = 5;
            this.padding_TB.Value = 50;
            this.padding_TB.Scroll += new System.EventHandler(this.padding_TB_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Timer width";
            // 
            // widthTB
            // 
            this.widthTB.Location = new System.Drawing.Point(12, 215);
            this.widthTB.Maximum = 20;
            this.widthTB.Minimum = 5;
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(328, 45);
            this.widthTB.TabIndex = 10;
            this.widthTB.Value = 5;
            this.widthTB.Scroll += new System.EventHandler(this.widthTB_Scroll);
            // 
            // darkModeCB
            // 
            this.darkModeCB.AutoSize = true;
            this.darkModeCB.Location = new System.Drawing.Point(12, 266);
            this.darkModeCB.Name = "darkModeCB";
            this.darkModeCB.Size = new System.Drawing.Size(79, 17);
            this.darkModeCB.TabIndex = 11;
            this.darkModeCB.Text = "Dark Mode";
            this.darkModeCB.UseVisualStyleBackColor = true;
            this.darkModeCB.CheckedChanged += new System.EventHandler(this.darkModeCB_CheckedChanged);
            // 
            // clearTaskButton
            // 
            this.clearTaskButton.Location = new System.Drawing.Point(174, 326);
            this.clearTaskButton.Name = "clearTaskButton";
            this.clearTaskButton.Size = new System.Drawing.Size(82, 23);
            this.clearTaskButton.TabIndex = 2;
            this.clearTaskButton.Text = "Clear Tasks";
            this.clearTaskButton.UseVisualStyleBackColor = true;
            this.clearTaskButton.Click += new System.EventHandler(this.clearTaskButton_Click);
            // 
            // autoDarkMode
            // 
            this.autoDarkMode.AutoSize = true;
            this.autoDarkMode.Location = new System.Drawing.Point(97, 266);
            this.autoDarkMode.Name = "autoDarkMode";
            this.autoDarkMode.Size = new System.Drawing.Size(129, 17);
            this.autoDarkMode.TabIndex = 11;
            this.autoDarkMode.Text = "Automatic Dark Mode";
            this.autoDarkMode.UseVisualStyleBackColor = true;
            this.autoDarkMode.CheckedChanged += new System.EventHandler(this.autoDarkMode_CheckedChanged);
            // 
            // TaskTraySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 592);
            this.Controls.Add(this.autoDarkMode);
            this.Controls.Add(this.darkModeCB);
            this.Controls.Add(this.widthTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.padding_TB);
            this.Controls.Add(this.paddingLBL);
            this.Controls.Add(this.restartTaskList);
            this.Controls.Add(this.stopTaskListBTN);
            this.Controls.Add(this.startTaskListBTN);
            this.Controls.Add(this.LoadTaskListBTN);
            this.Controls.Add(this.tasksListBox);
            this.Controls.Add(this.SaveTaskListBTN);
            this.Controls.Add(this.editTaskButton);
            this.Controls.Add(this.clearTaskButton);
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
            this.Text = "ProcrastinateMe Settings";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.TaskTraySettings_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskTraySettings_FormClosing);
            this.Load += new System.EventHandler(this.TaskTraySettings_Load);
            this.Click += new System.EventHandler(this.TaskTraySettings_Click);
            ((System.ComponentModel.ISupportInitialize)(this.timerSizeTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padding_TB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar timerSizeTB;
        private System.Windows.Forms.Label timerSizeLBL;
        private System.Windows.Forms.Button createTaskBTN;
        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.Button deleteTaskBTN;
        private System.Windows.Forms.Button LoadTaskListBTN;
        private System.Windows.Forms.Button startTaskListBTN;
        private System.Windows.Forms.Button stopTaskListBTN;
        private System.Windows.Forms.Button restartTaskList;
        private System.Windows.Forms.Button SaveTaskListBTN;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label paddingLBL;
        private System.Windows.Forms.TrackBar padding_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar widthTB;
        private System.Windows.Forms.CheckBox darkModeCB;
        private System.Windows.Forms.Button clearTaskButton;
        private System.Windows.Forms.CheckBox autoDarkMode;
    }
}