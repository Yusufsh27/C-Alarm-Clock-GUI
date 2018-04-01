namespace PA05
{
    partial class Form3
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.AddAP = new System.Windows.Forms.Button();
            this.Appointments = new System.Windows.Forms.Label();
            this.MemoOrg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursSet = new System.Windows.Forms.NumericUpDown();
            this.minutesSet = new System.Windows.Forms.NumericUpDown();
            this.secondsSet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateLB = new System.Windows.Forms.ListBox();
            this.memoLB = new System.Windows.Forms.ListBox();
            this.timeLB = new System.Windows.Forms.ListBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.help2Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoursSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSet)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 67);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // AddAP
            // 
            this.AddAP.Location = new System.Drawing.Point(283, 253);
            this.AddAP.Name = "AddAP";
            this.AddAP.Size = new System.Drawing.Size(123, 23);
            this.AddAP.TabIndex = 1;
            this.AddAP.Text = "Add Appointment";
            this.AddAP.UseVisualStyleBackColor = true;
            this.AddAP.Click += new System.EventHandler(this.button1_Click);
            // 
            // Appointments
            // 
            this.Appointments.AutoSize = true;
            this.Appointments.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointments.Location = new System.Drawing.Point(132, 5);
            this.Appointments.Name = "Appointments";
            this.Appointments.Size = new System.Drawing.Size(167, 33);
            this.Appointments.TabIndex = 3;
            this.Appointments.Text = "Appointments";
            // 
            // MemoOrg
            // 
            this.MemoOrg.Location = new System.Drawing.Point(259, 67);
            this.MemoOrg.Multiline = true;
            this.MemoOrg.Name = "MemoOrg";
            this.MemoOrg.Size = new System.Drawing.Size(148, 162);
            this.MemoOrg.TabIndex = 4;
            this.MemoOrg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hours";
            // 
            // hoursSet
            // 
            this.hoursSet.Location = new System.Drawing.Point(15, 256);
            this.hoursSet.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursSet.Name = "hoursSet";
            this.hoursSet.Size = new System.Drawing.Size(39, 20);
            this.hoursSet.TabIndex = 20;
            // 
            // minutesSet
            // 
            this.minutesSet.Location = new System.Drawing.Point(60, 256);
            this.minutesSet.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesSet.Name = "minutesSet";
            this.minutesSet.Size = new System.Drawing.Size(39, 20);
            this.minutesSet.TabIndex = 19;
            // 
            // secondsSet
            // 
            this.secondsSet.Location = new System.Drawing.Point(105, 256);
            this.secondsSet.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsSet.Name = "secondsSet";
            this.secondsSet.Size = new System.Drawing.Size(39, 20);
            this.secondsSet.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Date and Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Memo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Memo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 26);
            this.label9.TabIndex = 32;
            this.label9.Text = "Current Appointments";
            // 
            // dateLB
            // 
            this.dateLB.FormattingEnabled = true;
            this.dateLB.Location = new System.Drawing.Point(15, 359);
            this.dateLB.Name = "dateLB";
            this.dateLB.Size = new System.Drawing.Size(65, 160);
            this.dateLB.TabIndex = 33;
            // 
            // memoLB
            // 
            this.memoLB.FormattingEnabled = true;
            this.memoLB.HorizontalScrollbar = true;
            this.memoLB.Location = new System.Drawing.Point(168, 359);
            this.memoLB.MultiColumn = true;
            this.memoLB.Name = "memoLB";
            this.memoLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.memoLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.memoLB.Size = new System.Drawing.Size(238, 160);
            this.memoLB.TabIndex = 34;
            // 
            // timeLB
            // 
            this.timeLB.FormattingEnabled = true;
            this.timeLB.Location = new System.Drawing.Point(86, 359);
            this.timeLB.Name = "timeLB";
            this.timeLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.timeLB.Size = new System.Drawing.Size(76, 160);
            this.timeLB.TabIndex = 35;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(331, 330);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 36;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(238, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Set Reminder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(331, 301);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 38;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // help2Btn
            // 
            this.help2Btn.Location = new System.Drawing.Point(238, 301);
            this.help2Btn.Name = "help2Btn";
            this.help2Btn.Size = new System.Drawing.Size(85, 23);
            this.help2Btn.TabIndex = 39;
            this.help2Btn.Text = "Help";
            this.help2Btn.UseVisualStyleBackColor = true;
            this.help2Btn.Click += new System.EventHandler(this.help2Btn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 531);
            this.Controls.Add(this.help2Btn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.timeLB);
            this.Controls.Add(this.memoLB);
            this.Controls.Add(this.dateLB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursSet);
            this.Controls.Add(this.minutesSet);
            this.Controls.Add(this.secondsSet);
            this.Controls.Add(this.MemoOrg);
            this.Controls.Add(this.Appointments);
            this.Controls.Add(this.AddAP);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form3";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.hoursSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button AddAP;
        private System.Windows.Forms.Label Appointments;
        private System.Windows.Forms.TextBox MemoOrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hoursSet;
        private System.Windows.Forms.NumericUpDown minutesSet;
        private System.Windows.Forms.NumericUpDown secondsSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox dateLB;
        private System.Windows.Forms.ListBox memoLB;
        private System.Windows.Forms.ListBox timeLB;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button help2Btn;
    }
}