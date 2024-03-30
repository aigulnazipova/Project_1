namespace StudentDiary.Student
{
    partial class ScheduleStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleStudentForm));
            this.dgwStudentScheduleInfo = new System.Windows.Forms.DataGridView();
            this.tbWeekDay = new System.Windows.Forms.TextBox();
            this.cbWeekDay = new System.Windows.Forms.ComboBox();
            this.txtbChooseGroupNumber = new System.Windows.Forms.TextBox();
            this.cbGroupNumber = new System.Windows.Forms.ComboBox();
            this.txtbChooseFaculty = new System.Windows.Forms.TextBox();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.pbSchedule = new System.Windows.Forms.PictureBox();
            this.btnReturnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentScheduleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStudentScheduleInfo
            // 
            this.dgwStudentScheduleInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwStudentScheduleInfo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwStudentScheduleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentScheduleInfo.Location = new System.Drawing.Point(29, 171);
            this.dgwStudentScheduleInfo.Name = "dgwStudentScheduleInfo";
            this.dgwStudentScheduleInfo.RowHeadersWidth = 51;
            this.dgwStudentScheduleInfo.RowTemplate.Height = 24;
            this.dgwStudentScheduleInfo.Size = new System.Drawing.Size(879, 422);
            this.dgwStudentScheduleInfo.TabIndex = 0;
            // 
            // tbWeekDay
            // 
            this.tbWeekDay.BackColor = System.Drawing.SystemColors.Control;
            this.tbWeekDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWeekDay.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWeekDay.Location = new System.Drawing.Point(597, 105);
            this.tbWeekDay.Multiline = true;
            this.tbWeekDay.Name = "tbWeekDay";
            this.tbWeekDay.ReadOnly = true;
            this.tbWeekDay.Size = new System.Drawing.Size(246, 35);
            this.tbWeekDay.TabIndex = 34;
            this.tbWeekDay.Text = "День недели";
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
            this.cbWeekDay.Location = new System.Drawing.Point(597, 141);
            this.cbWeekDay.Name = "cbWeekDay";
            this.cbWeekDay.Size = new System.Drawing.Size(170, 24);
            this.cbWeekDay.TabIndex = 33;
            // 
            // txtbChooseGroupNumber
            // 
            this.txtbChooseGroupNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtbChooseGroupNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbChooseGroupNumber.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbChooseGroupNumber.Location = new System.Drawing.Point(393, 105);
            this.txtbChooseGroupNumber.Multiline = true;
            this.txtbChooseGroupNumber.Name = "txtbChooseGroupNumber";
            this.txtbChooseGroupNumber.ReadOnly = true;
            this.txtbChooseGroupNumber.Size = new System.Drawing.Size(246, 35);
            this.txtbChooseGroupNumber.TabIndex = 32;
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
            this.cbGroupNumber.Location = new System.Drawing.Point(393, 141);
            this.cbGroupNumber.Name = "cbGroupNumber";
            this.cbGroupNumber.Size = new System.Drawing.Size(170, 24);
            this.cbGroupNumber.TabIndex = 31;
            // 
            // txtbChooseFaculty
            // 
            this.txtbChooseFaculty.BackColor = System.Drawing.SystemColors.Control;
            this.txtbChooseFaculty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbChooseFaculty.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbChooseFaculty.Location = new System.Drawing.Point(187, 105);
            this.txtbChooseFaculty.Multiline = true;
            this.txtbChooseFaculty.Name = "txtbChooseFaculty";
            this.txtbChooseFaculty.ReadOnly = true;
            this.txtbChooseFaculty.Size = new System.Drawing.Size(215, 35);
            this.txtbChooseFaculty.TabIndex = 30;
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
            this.cbFaculty.Location = new System.Drawing.Point(187, 141);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(165, 24);
            this.cbFaculty.TabIndex = 29;
            // 
            // pbSchedule
            // 
            this.pbSchedule.Image = ((System.Drawing.Image)(resources.GetObject("pbSchedule.Image")));
            this.pbSchedule.Location = new System.Drawing.Point(260, 12);
            this.pbSchedule.Name = "pbSchedule";
            this.pbSchedule.Size = new System.Drawing.Size(539, 87);
            this.pbSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSchedule.TabIndex = 35;
            this.pbSchedule.TabStop = false;
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnReturnBack.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReturnBack.Location = new System.Drawing.Point(843, 1);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(94, 34);
            this.btnReturnBack.TabIndex = 36;
            this.btnReturnBack.Text = "Назад";
            this.btnReturnBack.UseVisualStyleBackColor = false;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // ScheduleStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 601);
            this.Controls.Add(this.btnReturnBack);
            this.Controls.Add(this.pbSchedule);
            this.Controls.Add(this.tbWeekDay);
            this.Controls.Add(this.cbWeekDay);
            this.Controls.Add(this.txtbChooseGroupNumber);
            this.Controls.Add(this.cbGroupNumber);
            this.Controls.Add(this.txtbChooseFaculty);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.dgwStudentScheduleInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScheduleStudentForm";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.ScheduleStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentScheduleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudentScheduleInfo;
        private System.Windows.Forms.TextBox tbWeekDay;
        private System.Windows.Forms.ComboBox cbWeekDay;
        private System.Windows.Forms.TextBox txtbChooseGroupNumber;
        private System.Windows.Forms.ComboBox cbGroupNumber;
        private System.Windows.Forms.TextBox txtbChooseFaculty;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.PictureBox pbSchedule;
        private System.Windows.Forms.Button btnReturnBack;
    }
}