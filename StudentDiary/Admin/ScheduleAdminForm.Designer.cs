﻿namespace StudentDiary.Admin
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
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminScheduleInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAdminScheduleInfo
            // 
            this.dgwAdminScheduleInfo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwAdminScheduleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdminScheduleInfo.Location = new System.Drawing.Point(0, 85);
            this.dgwAdminScheduleInfo.Name = "dgwAdminScheduleInfo";
            this.dgwAdminScheduleInfo.RowHeadersWidth = 51;
            this.dgwAdminScheduleInfo.RowTemplate.Height = 24;
            this.dgwAdminScheduleInfo.Size = new System.Drawing.Size(719, 471);
            this.dgwAdminScheduleInfo.TabIndex = 0;
            // 
            // ScheduleAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 556);
            this.Controls.Add(this.dgwAdminScheduleInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScheduleAdminForm";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.ScheduleAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminScheduleInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAdminScheduleInfo;
    }
}