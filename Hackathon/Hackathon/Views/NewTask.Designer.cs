
namespace Hackathon.Views
{
    partial class NewTask
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
            this.taskNameInput = new System.Windows.Forms.TextBox();
            this.TaskNameLBL = new System.Windows.Forms.Label();
            this.taskDurationLBL = new System.Windows.Forms.Label();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.timerColorPicker = new System.Windows.Forms.ColorDialog();
            this.ColorLBL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minutesSelect = new System.Windows.Forms.NumericUpDown();
            this.secondsSelect = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // taskNameInput
            // 
            this.taskNameInput.Location = new System.Drawing.Point(12, 29);
            this.taskNameInput.Name = "taskNameInput";
            this.taskNameInput.Size = new System.Drawing.Size(163, 20);
            this.taskNameInput.TabIndex = 0;
            // 
            // TaskNameLBL
            // 
            this.TaskNameLBL.AutoSize = true;
            this.TaskNameLBL.Location = new System.Drawing.Point(13, 13);
            this.TaskNameLBL.Name = "TaskNameLBL";
            this.TaskNameLBL.Size = new System.Drawing.Size(62, 13);
            this.TaskNameLBL.TabIndex = 1;
            this.TaskNameLBL.Text = "Task Name";
            // 
            // taskDurationLBL
            // 
            this.taskDurationLBL.AutoSize = true;
            this.taskDurationLBL.Location = new System.Drawing.Point(13, 63);
            this.taskDurationLBL.Name = "taskDurationLBL";
            this.taskDurationLBL.Size = new System.Drawing.Size(110, 13);
            this.taskDurationLBL.TabIndex = 3;
            this.taskDurationLBL.Text = "Task duration (mm:ss)";
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(93, 147);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 4;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(12, 147);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBTN.TabIndex = 5;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // timerColorPicker
            // 
            this.timerColorPicker.AnyColor = true;
            this.timerColorPicker.FullOpen = true;
            // 
            // ColorLBL
            // 
            this.ColorLBL.AutoSize = true;
            this.ColorLBL.Location = new System.Drawing.Point(17, 122);
            this.ColorLBL.Name = "ColorLBL";
            this.ColorLBL.Size = new System.Drawing.Size(31, 13);
            this.ColorLBL.TabIndex = 6;
            this.ColorLBL.Text = "Color";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(54, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minutesSelect
            // 
            this.minutesSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minutesSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minutesSelect.Location = new System.Drawing.Point(12, 79);
            this.minutesSelect.Name = "minutesSelect";
            this.minutesSelect.Size = new System.Drawing.Size(59, 20);
            this.minutesSelect.TabIndex = 8;
            this.minutesSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondsSelect
            // 
            this.secondsSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondsSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.secondsSelect.Location = new System.Drawing.Point(77, 79);
            this.secondsSelect.Name = "secondsSelect";
            this.secondsSelect.Size = new System.Drawing.Size(59, 20);
            this.secondsSelect.TabIndex = 8;
            this.secondsSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 183);
            this.Controls.Add(this.secondsSelect);
            this.Controls.Add(this.minutesSelect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ColorLBL);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.taskDurationLBL);
            this.Controls.Add(this.TaskNameLBL);
            this.Controls.Add(this.taskNameInput);
            this.Name = "NewTask";
            this.Text = "NewTask";
            this.Load += new System.EventHandler(this.NewTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taskNameInput;
        private System.Windows.Forms.Label TaskNameLBL;
        private System.Windows.Forms.Label taskDurationLBL;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.ColorDialog timerColorPicker;
        private System.Windows.Forms.Label ColorLBL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown minutesSelect;
        private System.Windows.Forms.NumericUpDown secondsSelect;
    }
}