﻿namespace StudentDiary.Admin
{
    partial class GiveGradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveGradeForm));
            this.pbGiveGrade = new System.Windows.Forms.PictureBox();
            this.btnReturnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGiveGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGiveGrade
            // 
            this.pbGiveGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.pbGiveGrade.Image = ((System.Drawing.Image)(resources.GetObject("pbGiveGrade.Image")));
            this.pbGiveGrade.Location = new System.Drawing.Point(51, 41);
            this.pbGiveGrade.Name = "pbGiveGrade";
            this.pbGiveGrade.Size = new System.Drawing.Size(438, 159);
            this.pbGiveGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGiveGrade.TabIndex = 0;
            this.pbGiveGrade.TabStop = false;
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnReturnBack.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReturnBack.Location = new System.Drawing.Point(453, 1);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(94, 34);
            this.btnReturnBack.TabIndex = 6;
            this.btnReturnBack.Text = "Назад";
            this.btnReturnBack.UseVisualStyleBackColor = false;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // GiveGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 627);
            this.Controls.Add(this.btnReturnBack);
            this.Controls.Add(this.pbGiveGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GiveGradeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbGiveGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGiveGrade;
        private System.Windows.Forms.Button btnReturnBack;
    }
}