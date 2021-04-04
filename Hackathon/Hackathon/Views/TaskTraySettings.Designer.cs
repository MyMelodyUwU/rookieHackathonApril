
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
            ((System.ComponentModel.ISupportInitialize)(this.timerSizeTB)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSizeTB
            // 
            this.timerSizeTB.LargeChange = 50;
            this.timerSizeTB.Location = new System.Drawing.Point(12, 60);
            this.timerSizeTB.Maximum = 200;
            this.timerSizeTB.Minimum = 50;
            this.timerSizeTB.Name = "timerSizeTB";
            this.timerSizeTB.Size = new System.Drawing.Size(260, 45);
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
            this.timerSizeLBL.Location = new System.Drawing.Point(9, 44);
            this.timerSizeLBL.Name = "timerSizeLBL";
            this.timerSizeLBL.Size = new System.Drawing.Size(54, 13);
            this.timerSizeLBL.TabIndex = 1;
            this.timerSizeLBL.Text = "Timer size";
            // 
            // createTaskBTN
            // 
            this.createTaskBTN.Location = new System.Drawing.Point(16, 139);
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
            this.tasksListBox.Location = new System.Drawing.Point(16, 168);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(256, 225);
            this.tasksListBox.TabIndex = 3;
            // 
            // deleteTaskBTN
            // 
            this.deleteTaskBTN.Location = new System.Drawing.Point(97, 139);
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
            this.comboBox1.Location = new System.Drawing.Point(16, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // LoadTaskListBTN
            // 
            this.LoadTaskListBTN.Location = new System.Drawing.Point(178, 111);
            this.LoadTaskListBTN.Name = "LoadTaskListBTN";
            this.LoadTaskListBTN.Size = new System.Drawing.Size(94, 21);
            this.LoadTaskListBTN.TabIndex = 5;
            this.LoadTaskListBTN.Text = "Load Task List";
            this.LoadTaskListBTN.UseVisualStyleBackColor = true;
            // 
            // startTaskListBTN
            // 
            this.startTaskListBTN.Location = new System.Drawing.Point(12, 12);
            this.startTaskListBTN.Name = "startTaskListBTN";
            this.startTaskListBTN.Size = new System.Drawing.Size(126, 23);
            this.startTaskListBTN.TabIndex = 6;
            this.startTaskListBTN.Text = "Start task list";
            this.startTaskListBTN.UseVisualStyleBackColor = true;
            // 
            // stopTaskListBTN
            // 
            this.stopTaskListBTN.Location = new System.Drawing.Point(144, 12);
            this.stopTaskListBTN.Name = "stopTaskListBTN";
            this.stopTaskListBTN.Size = new System.Drawing.Size(128, 23);
            this.stopTaskListBTN.TabIndex = 6;
            this.stopTaskListBTN.Text = "Stop task list";
            this.stopTaskListBTN.UseVisualStyleBackColor = true;
            // 
            // TaskTraySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.stopTaskListBTN);
            this.Controls.Add(this.startTaskListBTN);
            this.Controls.Add(this.LoadTaskListBTN);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tasksListBox);
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
    }
}