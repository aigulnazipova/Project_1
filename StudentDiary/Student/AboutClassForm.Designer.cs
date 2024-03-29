namespace StudentDiary.Student
{
    partial class AboutClassForm
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
            this.dgwAboutClassesInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAboutClassesInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAboutClassesInfo
            // 
            this.dgwAboutClassesInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwAboutClassesInfo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwAboutClassesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAboutClassesInfo.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwAboutClassesInfo.Location = new System.Drawing.Point(338, 0);
            this.dgwAboutClassesInfo.Name = "dgwAboutClassesInfo";
            this.dgwAboutClassesInfo.ReadOnly = true;
            this.dgwAboutClassesInfo.RowHeadersWidth = 51;
            this.dgwAboutClassesInfo.RowTemplate.Height = 24;
            this.dgwAboutClassesInfo.Size = new System.Drawing.Size(563, 590);
            this.dgwAboutClassesInfo.TabIndex = 0;
            // 
            // AboutClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 591);
            this.Controls.Add(this.dgwAboutClassesInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutClassForm";
            this.Text = "О занятиях";
            this.Load += new System.EventHandler(this.AboutClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAboutClassesInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAboutClassesInfo;
    }
}