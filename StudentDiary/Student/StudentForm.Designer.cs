namespace StudentDiary
{
    partial class StudentForm
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
            this.btnReturnBack = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnStudentAccount = new System.Windows.Forms.Button();
            this.btnAboutClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnReturnBack.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReturnBack.Location = new System.Drawing.Point(389, -1);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(94, 34);
            this.btnReturnBack.TabIndex = 10;
            this.btnReturnBack.Text = "Назад";
            this.btnReturnBack.UseVisualStyleBackColor = false;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSchedule.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSchedule.Location = new System.Drawing.Point(56, 245);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(370, 60);
            this.btnSchedule.TabIndex = 8;
            this.btnSchedule.Text = "Расписание";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnStudentAccount
            // 
            this.btnStudentAccount.BackColor = System.Drawing.Color.RosyBrown;
            this.btnStudentAccount.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudentAccount.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStudentAccount.Location = new System.Drawing.Point(56, 149);
            this.btnStudentAccount.Name = "btnStudentAccount";
            this.btnStudentAccount.Size = new System.Drawing.Size(370, 63);
            this.btnStudentAccount.TabIndex = 6;
            this.btnStudentAccount.Text = "Личный кабинет";
            this.btnStudentAccount.UseVisualStyleBackColor = false;
            this.btnStudentAccount.Click += new System.EventHandler(this.studentAccountButton_Click);
            // 
            // btnAboutClass
            // 
            this.btnAboutClass.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAboutClass.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAboutClass.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAboutClass.Location = new System.Drawing.Point(56, 340);
            this.btnAboutClass.Name = "btnAboutClass";
            this.btnAboutClass.Size = new System.Drawing.Size(370, 60);
            this.btnAboutClass.TabIndex = 11;
            this.btnAboutClass.Text = "О занятиях";
            this.btnAboutClass.UseVisualStyleBackColor = false;
            this.btnAboutClass.Click += new System.EventHandler(this.btnAboutClass_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 590);
            this.Controls.Add(this.btnAboutClass);
            this.Controls.Add(this.btnReturnBack);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnStudentAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturnBack;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnStudentAccount;
        private System.Windows.Forms.Button btnAboutClass;
    }
}