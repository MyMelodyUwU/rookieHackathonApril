
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
            // TaskTraySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
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
    }
}