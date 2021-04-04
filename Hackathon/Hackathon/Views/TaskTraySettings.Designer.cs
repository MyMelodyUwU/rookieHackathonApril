
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
            this.tasksScrollBar = new System.Windows.Forms.VScrollBar();
            this.deleteTaskBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timerSizeTB)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSizeTB
            // 
            this.timerSizeTB.LargeChange = 50;
            this.timerSizeTB.Location = new System.Drawing.Point(12, 34);
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
            this.timerSizeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerSizeLBL.Location = new System.Drawing.Point(13, 13);
            this.timerSizeLBL.Name = "timerSizeLBL";
            this.timerSizeLBL.Size = new System.Drawing.Size(77, 18);
            this.timerSizeLBL.TabIndex = 1;
            this.timerSizeLBL.Text = "Timer size";
            // 
            // createTaskBTN
            // 
            this.createTaskBTN.Location = new System.Drawing.Point(16, 87);
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
            this.tasksListBox.Location = new System.Drawing.Point(16, 116);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(239, 277);
            this.tasksListBox.TabIndex = 3;
            // 
            // tasksScrollBar
            // 
            this.tasksScrollBar.Location = new System.Drawing.Point(258, 116);
            this.tasksScrollBar.Name = "tasksScrollBar";
            this.tasksScrollBar.Size = new System.Drawing.Size(17, 267);
            this.tasksScrollBar.TabIndex = 4;
            // 
            // deleteTaskBTN
            // 
            this.deleteTaskBTN.Location = new System.Drawing.Point(97, 87);
            this.deleteTaskBTN.Name = "deleteTaskBTN";
            this.deleteTaskBTN.Size = new System.Drawing.Size(75, 23);
            this.deleteTaskBTN.TabIndex = 2;
            this.deleteTaskBTN.Text = "Delete Task";
            this.deleteTaskBTN.UseVisualStyleBackColor = true;
            this.deleteTaskBTN.Click += new System.EventHandler(this.createTaskBTN_Click);
            // 
            // TaskTraySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.tasksScrollBar);
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
            ((System.ComponentModel.ISupportInitialize)(this.timerSizeTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar timerSizeTB;
        private System.Windows.Forms.Label timerSizeLBL;
        private System.Windows.Forms.Button createTaskBTN;
        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.VScrollBar tasksScrollBar;
        private System.Windows.Forms.Button deleteTaskBTN;
    }
}