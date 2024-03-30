namespace StudentDiary.Admin
{
    partial class ScheduleAdminForm
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
            this.dgwAdminScheduleInfo = new System.Windows.Forms.DataGridView();
            this.txtbChooseFaculty = new System.Windows.Forms.TextBox();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.txtbChooseGroupNumber = new System.Windows.Forms.TextBox();
            this.cbGroupNumber = new System.Windows.Forms.ComboBox();
            this.tbAddClass = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tbGroupNumber = new System.Windows.Forms.TextBox();
            this.tbFaculty = new System.Windows.Forms.TextBox();
            this.tbWeekDay = new System.Windows.Forms.TextBox();
            this.tbClassNumber = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbFormat = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.cbWeekDay = new System.Windows.Forms.ComboBox();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnReturnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminScheduleInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAdminScheduleInfo
            // 
            this.dgwAdminScheduleInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwAdminScheduleInfo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwAdminScheduleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdminScheduleInfo.Location = new System.Drawing.Point(371, 98);
            this.dgwAdminScheduleInfo.Name = "dgwAdminScheduleInfo";
            this.dgwAdminScheduleInfo.RowHeadersWidth = 51;
            this.dgwAdminScheduleInfo.RowTemplate.Height = 24;
            this.dgwAdminScheduleInfo.Size = new System.Drawing.Size(793, 536);
            this.dgwAdminScheduleInfo.TabIndex = 0;
            // 
            // txtbChooseFaculty
            // 
            this.txtbChooseFaculty.BackColor = System.Drawing.SystemColors.Control;
            this.txtbChooseFaculty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbChooseFaculty.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbChooseFaculty.Location = new System.Drawing.Point(386, 16);
            this.txtbChooseFaculty.Multiline = true;
            this.txtbChooseFaculty.Name = "txtbChooseFaculty";
            this.txtbChooseFaculty.ReadOnly = true;
            this.txtbChooseFaculty.Size = new System.Drawing.Size(215, 35);
            this.txtbChooseFaculty.TabIndex = 6;
            this.txtbChooseFaculty.Text = "Направление";
            // 
            // cbFaculty
            // 
            this.cbFaculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Items.AddRange(new object[] {
            "Бизнес информатика",
            "Прикладная математика",
            "Прикладная информатика"});
            this.cbFaculty.Location = new System.Drawing.Point(386, 52);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(165, 24);
            this.cbFaculty.TabIndex = 5;
            // 
            // txtbChooseGroupNumber
            // 
            this.txtbChooseGroupNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtbChooseGroupNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbChooseGroupNumber.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbChooseGroupNumber.Location = new System.Drawing.Point(592, 16);
            this.txtbChooseGroupNumber.Multiline = true;
            this.txtbChooseGroupNumber.Name = "txtbChooseGroupNumber";
            this.txtbChooseGroupNumber.ReadOnly = true;
            this.txtbChooseGroupNumber.Size = new System.Drawing.Size(246, 35);
            this.txtbChooseGroupNumber.TabIndex = 8;
            this.txtbChooseGroupNumber.Text = "Номер группы";
            // 
            // cbGroupNumber
            // 
            this.cbGroupNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.cbGroupNumber.FormattingEnabled = true;
            this.cbGroupNumber.Items.AddRange(new object[] {
            "9301",
            "9311",
            "9321",
            "9322"});
            this.cbGroupNumber.Location = new System.Drawing.Point(592, 52);
            this.cbGroupNumber.Name = "cbGroupNumber";
            this.cbGroupNumber.Size = new System.Drawing.Size(170, 24);
            this.cbGroupNumber.TabIndex = 7;
            // 
            // tbAddClass
            // 
            this.tbAddClass.BackColor = System.Drawing.SystemColors.Control;
            this.tbAddClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddClass.Font = new System.Drawing.Font("Sitka Small", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddClass.Location = new System.Drawing.Point(21, 7);
            this.tbAddClass.Multiline = true;
            this.tbAddClass.Name = "tbAddClass";
            this.tbAddClass.ReadOnly = true;
            this.tbAddClass.Size = new System.Drawing.Size(346, 35);
            this.tbAddClass.TabIndex = 9;
            this.tbAddClass.Text = "Добавить занятие";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(59, 41);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(225, 35);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Номер группы";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(59, 101);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(156, 35);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Направление";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(59, 165);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(156, 35);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "День недели";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(59, 228);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(156, 35);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Номер пары";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(59, 290);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(156, 35);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "Предмет";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(59, 352);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(156, 35);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "Формат";
            // 
            // tbGroupNumber
            // 
            this.tbGroupNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.tbGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGroupNumber.Location = new System.Drawing.Point(59, 73);
            this.tbGroupNumber.Multiline = true;
            this.tbGroupNumber.Name = "tbGroupNumber";
            this.tbGroupNumber.Size = new System.Drawing.Size(225, 27);
            this.tbGroupNumber.TabIndex = 20;
            // 
            // tbFaculty
            // 
            this.tbFaculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.tbFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFaculty.Location = new System.Drawing.Point(59, 132);
            this.tbFaculty.Multiline = true;
            this.tbFaculty.Name = "tbFaculty";
            this.tbFaculty.Size = new System.Drawing.Size(225, 27);
            this.tbFaculty.TabIndex = 21;
            // 
            // tbWeekDay
            // 
            this.tbWeekDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.tbWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWeekDay.Location = new System.Drawing.Point(59, 195);
            this.tbWeekDay.Multiline = true;
            this.tbWeekDay.Name = "tbWeekDay";
            this.tbWeekDay.Size = new System.Drawing.Size(225, 27);
            this.tbWeekDay.TabIndex = 22;
            // 
            // tbClassNumber
            // 
            this.tbClassNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.tbClassNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbClassNumber.Location = new System.Drawing.Point(59, 257);
            this.tbClassNumber.Multiline = true;
            this.tbClassNumber.Name = "tbClassNumber";
            this.tbClassNumber.Size = new System.Drawing.Size(225, 27);
            this.tbClassNumber.TabIndex = 23;
            // 
            // tbSubject
            // 
            this.tbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.tbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSubject.Location = new System.Drawing.Point(59, 319);
            this.tbSubject.Multiline = true;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(225, 27);
            this.tbSubject.TabIndex = 24;
            // 
            // tbFormat
            // 
            this.tbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.tbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFormat.Location = new System.Drawing.Point(59, 383);
            this.tbFormat.Multiline = true;
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(225, 27);
            this.tbFormat.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(109, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 38);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(796, 16);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(246, 35);
            this.textBox8.TabIndex = 28;
            this.textBox8.Text = "День недели";
            // 
            // cbWeekDay
            // 
            this.cbWeekDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.cbWeekDay.FormattingEnabled = true;
            this.cbWeekDay.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.cbWeekDay.Location = new System.Drawing.Point(796, 52);
            this.cbWeekDay.Name = "cbWeekDay";
            this.cbWeekDay.Size = new System.Drawing.Size(170, 24);
            this.cbWeekDay.TabIndex = 27;
            this.cbWeekDay.SelectedIndexChanged += new System.EventHandler(this.cbWeekDay_SelectedIndexChanged);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteRow.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteRow.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteRow.Location = new System.Drawing.Point(50, 505);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(243, 52);
            this.btnDeleteRow.TabIndex = 29;
            this.btnDeleteRow.Text = "Удалить запись";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnReturnBack.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReturnBack.Location = new System.Drawing.Point(1070, 7);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(94, 34);
            this.btnReturnBack.TabIndex = 30;
            this.btnReturnBack.Text = "Назад";
            this.btnReturnBack.UseVisualStyleBackColor = false;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // ScheduleAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 638);
            this.Controls.Add(this.btnReturnBack);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.cbWeekDay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbFormat);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbClassNumber);
            this.Controls.Add(this.tbWeekDay);
            this.Controls.Add(this.tbFaculty);
            this.Controls.Add(this.tbGroupNumber);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbAddClass);
            this.Controls.Add(this.txtbChooseGroupNumber);
            this.Controls.Add(this.cbGroupNumber);
            this.Controls.Add(this.txtbChooseFaculty);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.dgwAdminScheduleInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScheduleAdminForm";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.ScheduleAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminScheduleInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAdminScheduleInfo;
        private System.Windows.Forms.TextBox txtbChooseFaculty;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.TextBox txtbChooseGroupNumber;
        private System.Windows.Forms.ComboBox cbGroupNumber;
        private System.Windows.Forms.TextBox tbAddClass;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tbGroupNumber;
        private System.Windows.Forms.TextBox tbFaculty;
        private System.Windows.Forms.TextBox tbWeekDay;
        private System.Windows.Forms.TextBox tbClassNumber;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbFormat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox cbWeekDay;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnReturnBack;
    }
}