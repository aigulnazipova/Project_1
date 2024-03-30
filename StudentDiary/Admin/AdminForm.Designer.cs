namespace StudentDiary
{
    partial class AdminForm
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
            this.adminAccountButton = new System.Windows.Forms.Button();
            this.btnStudyGroup = new System.Windows.Forms.Button();
            this.btnScheduleAdminForm = new System.Windows.Forms.Button();
            this.btnGiveGrade = new System.Windows.Forms.Button();
            this.btnReturnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminAccountButton
            // 
            this.adminAccountButton.BackColor = System.Drawing.Color.RosyBrown;
            this.adminAccountButton.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminAccountButton.ForeColor = System.Drawing.SystemColors.Window;
            this.adminAccountButton.Location = new System.Drawing.Point(57, 92);
            this.adminAccountButton.Name = "adminAccountButton";
            this.adminAccountButton.Size = new System.Drawing.Size(370, 63);
            this.adminAccountButton.TabIndex = 0;
            this.adminAccountButton.Text = "Личный кабинет";
            this.adminAccountButton.UseVisualStyleBackColor = false;
            this.adminAccountButton.Click += new System.EventHandler(this.adminAccountButton_Click);
            // 
            // btnStudyGroup
            // 
            this.btnStudyGroup.BackColor = System.Drawing.Color.RosyBrown;
            this.btnStudyGroup.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudyGroup.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStudyGroup.Location = new System.Drawing.Point(57, 194);
            this.btnStudyGroup.Name = "btnStudyGroup";
            this.btnStudyGroup.Size = new System.Drawing.Size(370, 63);
            this.btnStudyGroup.TabIndex = 1;
            this.btnStudyGroup.Text = "Учебные группы";
            this.btnStudyGroup.UseVisualStyleBackColor = false;
            this.btnStudyGroup.Click += new System.EventHandler(this.btnStudyGroup_Click);
            // 
            // btnScheduleAdminForm
            // 
            this.btnScheduleAdminForm.BackColor = System.Drawing.Color.RosyBrown;
            this.btnScheduleAdminForm.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScheduleAdminForm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnScheduleAdminForm.Location = new System.Drawing.Point(57, 293);
            this.btnScheduleAdminForm.Name = "btnScheduleAdminForm";
            this.btnScheduleAdminForm.Size = new System.Drawing.Size(370, 60);
            this.btnScheduleAdminForm.TabIndex = 2;
            this.btnScheduleAdminForm.Text = "Расписание";
            this.btnScheduleAdminForm.UseVisualStyleBackColor = false;
            this.btnScheduleAdminForm.Click += new System.EventHandler(this.btnScheduleAdminForm_Click);
            // 
            // btnGiveGrade
            // 
            this.btnGiveGrade.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGiveGrade.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGiveGrade.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGiveGrade.Location = new System.Drawing.Point(57, 393);
            this.btnGiveGrade.Name = "btnGiveGrade";
            this.btnGiveGrade.Size = new System.Drawing.Size(370, 60);
            this.btnGiveGrade.TabIndex = 3;
            this.btnGiveGrade.Text = "Выставить баллы";
            this.btnGiveGrade.UseVisualStyleBackColor = false;
            this.btnGiveGrade.Click += new System.EventHandler(this.btnGiveGrade_Click);
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnReturnBack.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReturnBack.Location = new System.Drawing.Point(389, 1);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(94, 34);
            this.btnReturnBack.TabIndex = 5;
            this.btnReturnBack.Text = "Назад";
            this.btnReturnBack.UseVisualStyleBackColor = false;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(483, 590);
            this.Controls.Add(this.btnReturnBack);
            this.Controls.Add(this.btnGiveGrade);
            this.Controls.Add(this.btnScheduleAdminForm);
            this.Controls.Add(this.btnStudyGroup);
            this.Controls.Add(this.adminAccountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminAccountButton;
        private System.Windows.Forms.Button btnStudyGroup;
        private System.Windows.Forms.Button btnScheduleAdminForm;
        private System.Windows.Forms.Button btnGiveGrade;
        private System.Windows.Forms.Button btnReturnBack;
    }
}