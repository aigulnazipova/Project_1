namespace StudentDiary
{
    partial class StudyGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyGroupForm));
            this.pbStudyGroup = new System.Windows.Forms.PictureBox();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.txtbChooseFaculty = new System.Windows.Forms.TextBox();
            this.txtbChooseGroupNumber = new System.Windows.Forms.TextBox();
            this.cbGroupNumber = new System.Windows.Forms.ComboBox();
            this.dgwStudyGroupInfo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudyGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudyGroupInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStudyGroup
            // 
            this.pbStudyGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.pbStudyGroup.Image = ((System.Drawing.Image)(resources.GetObject("pbStudyGroup.Image")));
            this.pbStudyGroup.Location = new System.Drawing.Point(582, 12);
            this.pbStudyGroup.Name = "pbStudyGroup";
            this.pbStudyGroup.Size = new System.Drawing.Size(484, 85);
            this.pbStudyGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudyGroup.TabIndex = 0;
            this.pbStudyGroup.TabStop = false;
            // 
            // cbFaculty
            // 
            this.cbFaculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Items.AddRange(new object[] {
            "Бизнес информатика",
            "Прикладная математика",
            "Прикладная информатика"});
            this.cbFaculty.Location = new System.Drawing.Point(25, 144);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(178, 24);
            this.cbFaculty.TabIndex = 1;
            this.cbFaculty.SelectedIndexChanged += new System.EventHandler(this.cbFaculty_SelectedIndexChanged);
            // 
            // txtbChooseFaculty
            // 
            this.txtbChooseFaculty.BackColor = System.Drawing.SystemColors.Control;
            this.txtbChooseFaculty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbChooseFaculty.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbChooseFaculty.Location = new System.Drawing.Point(-2, 103);
            this.txtbChooseFaculty.Multiline = true;
            this.txtbChooseFaculty.Name = "txtbChooseFaculty";
            this.txtbChooseFaculty.Size = new System.Drawing.Size(300, 35);
            this.txtbChooseFaculty.TabIndex = 4;
            this.txtbChooseFaculty.Text = "Выберите направление";
            // 
            // txtbChooseGroupNumber
            // 
            this.txtbChooseGroupNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtbChooseGroupNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbChooseGroupNumber.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbChooseGroupNumber.Location = new System.Drawing.Point(-2, 174);
            this.txtbChooseGroupNumber.Multiline = true;
            this.txtbChooseGroupNumber.Name = "txtbChooseGroupNumber";
            this.txtbChooseGroupNumber.Size = new System.Drawing.Size(320, 35);
            this.txtbChooseGroupNumber.TabIndex = 6;
            this.txtbChooseGroupNumber.Text = "Выберите номер группы";
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
            this.cbGroupNumber.Location = new System.Drawing.Point(25, 215);
            this.cbGroupNumber.Name = "cbGroupNumber";
            this.cbGroupNumber.Size = new System.Drawing.Size(178, 24);
            this.cbGroupNumber.TabIndex = 5;
            this.cbGroupNumber.SelectedIndexChanged += new System.EventHandler(this.cbGroupNumber_SelectedIndexChanged);
            // 
            // dgwStudyGroupInfo
            // 
            this.dgwStudyGroupInfo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwStudyGroupInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwStudyGroupInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudyGroupInfo.Location = new System.Drawing.Point(304, 100);
            this.dgwStudyGroupInfo.Name = "dgwStudyGroupInfo";
            this.dgwStudyGroupInfo.RowHeadersWidth = 51;
            this.dgwStudyGroupInfo.RowTemplate.Height = 24;
            this.dgwStudyGroupInfo.Size = new System.Drawing.Size(1073, 536);
            this.dgwStudyGroupInfo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(25, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Внести изменения";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(25, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(254, 50);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Удалить студента";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCreateStudent.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateStudent.Location = new System.Drawing.Point(25, 447);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(254, 52);
            this.btnCreateStudent.TabIndex = 14;
            this.btnCreateStudent.Text = "Добавить студента";
            this.btnCreateStudent.UseVisualStyleBackColor = false;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // StudyGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 638);
            this.Controls.Add(this.btnCreateStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwStudyGroupInfo);
            this.Controls.Add(this.txtbChooseGroupNumber);
            this.Controls.Add(this.cbGroupNumber);
            this.Controls.Add(this.txtbChooseFaculty);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.pbStudyGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudyGroupForm";
            this.Load += new System.EventHandler(this.StudyGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudyGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudyGroupInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStudyGroup;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.TextBox txtbChooseFaculty;
        private System.Windows.Forms.TextBox txtbChooseGroupNumber;
        private System.Windows.Forms.ComboBox cbGroupNumber;
        private System.Windows.Forms.DataGridView dgwStudyGroupInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateStudent;
    }
}