namespace PA05
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursSet = new System.Windows.Forms.NumericUpDown();
            this.minutesSet = new System.Windows.Forms.NumericUpDown();
            this.secondsSet = new System.Windows.Forms.NumericUpDown();
            this.setBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.hoursSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Hours";
            // 
            // hoursSet
            // 
            this.hoursSet.Location = new System.Drawing.Point(26, 207);
            this.hoursSet.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursSet.Name = "hoursSet";
            this.hoursSet.Size = new System.Drawing.Size(39, 20);
            this.hoursSet.TabIndex = 28;
            // 
            // minutesSet
            // 
            this.minutesSet.Location = new System.Drawing.Point(71, 207);
            this.minutesSet.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesSet.Name = "minutesSet";
            this.minutesSet.Size = new System.Drawing.Size(39, 20);
            this.minutesSet.TabIndex = 27;
            // 
            // secondsSet
            // 
            this.secondsSet.Location = new System.Drawing.Point(116, 207);
            this.secondsSet.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsSet.Name = "secondsSet";
            this.secondsSet.Size = new System.Drawing.Size(39, 20);
            this.secondsSet.TabIndex = 26;
            // 
            // setBtn
            // 
            this.setBtn.Location = new System.Drawing.Point(168, 204);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(77, 23);
            this.setBtn.TabIndex = 25;
            this.setBtn.Text = "Set";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 248);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursSet);
            this.Controls.Add(this.minutesSet);
            this.Controls.Add(this.secondsSet);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form4";
            this.Text = "Set Reminder";
            ((System.ComponentModel.ISupportInitialize)(this.hoursSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hoursSet;
        private System.Windows.Forms.NumericUpDown minutesSet;
        private System.Windows.Forms.NumericUpDown secondsSet;
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}