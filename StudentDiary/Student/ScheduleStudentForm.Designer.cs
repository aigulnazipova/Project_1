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
            this.dgwStudentScheduleInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentScheduleInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStudentScheduleInfo
            // 
            this.dgwStudentScheduleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentScheduleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwStudentScheduleInfo.Location = new System.Drawing.Point(0, 0);
            this.dgwStudentScheduleInfo.Name = "dgwStudentScheduleInfo";
            this.dgwStudentScheduleInfo.RowHeadersWidth = 51;
            this.dgwStudentScheduleInfo.RowTemplate.Height = 24;
            this.dgwStudentScheduleInfo.Size = new System.Drawing.Size(800, 450);
            this.dgwStudentScheduleInfo.TabIndex = 0;
            // 
            // ScheduleStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwStudentScheduleInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScheduleStudentForm";
            this.Text = "Расписание";
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentScheduleInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudentScheduleInfo;
    }
}