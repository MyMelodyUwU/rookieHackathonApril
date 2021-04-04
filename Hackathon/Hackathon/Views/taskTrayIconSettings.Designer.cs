
namespace Hackathon.Views
{
    partial class taskTrayIconSettings
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
            this.closeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Location = new System.Drawing.Point(9, 9);
            this.closeBTN.Margin = new System.Windows.Forms.Padding(0);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(57, 27);
            this.closeBTN.TabIndex = 0;
            this.closeBTN.Text = "Quit";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // taskTrayIconSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(75, 45);
            this.ControlBox = false;
            this.Controls.Add(this.closeBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "taskTrayIconSettings";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "taskTrayIconSettings";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
    }
}