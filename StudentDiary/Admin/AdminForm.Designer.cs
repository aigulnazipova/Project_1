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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RosyBrown;
            this.button3.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(57, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(370, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Расписание";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RosyBrown;
            this.button4.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(57, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(370, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Выставить баллы";
            this.button4.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStudyGroup);
            this.Controls.Add(this.adminAccountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminAccountButton;
        private System.Windows.Forms.Button btnStudyGroup;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnReturnBack;
    }
}