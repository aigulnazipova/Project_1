namespace StudentDiary.Student
{
    partial class WatchNoteForm
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
            this.lblChooseSubject = new System.Windows.Forms.Label();
            this.btnWatchNote = new System.Windows.Forms.Button();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblChooseSubject
            // 
            this.lblChooseSubject.AutoSize = true;
            this.lblChooseSubject.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseSubject.Location = new System.Drawing.Point(288, -51);
            this.lblChooseSubject.Name = "lblChooseSubject";
            this.lblChooseSubject.Size = new System.Drawing.Size(217, 29);
            this.lblChooseSubject.TabIndex = 7;
            this.lblChooseSubject.Text = "Выберите предмет";
            // 
            // btnWatchNote
            // 
            this.btnWatchNote.BackColor = System.Drawing.Color.RosyBrown;
            this.btnWatchNote.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWatchNote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWatchNote.Location = new System.Drawing.Point(139, 531);
            this.btnWatchNote.Name = "btnWatchNote";
            this.btnWatchNote.Size = new System.Drawing.Size(197, 37);
            this.btnWatchNote.TabIndex = 11;
            this.btnWatchNote.Text = "Просмотреть";
            this.btnWatchNote.UseVisualStyleBackColor = false;
            this.btnWatchNote.Click += new System.EventHandler(this.btnWatchNote_Click);
            // 
            // cbSubject
            // 
            this.cbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Items.AddRange(new object[] {
            "Алгебра и геометрия",
            "Математический анализ",
            "Программирование",
            "История России",
            "Иностранный язык",
            "Русский язык",
            "Правоведение",
            "Физическая культура"});
            this.cbSubject.Location = new System.Drawing.Point(139, 47);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(189, 24);
            this.cbSubject.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите предмет";
            // 
            // tbNote
            // 
            this.tbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNote.Location = new System.Drawing.Point(1, 77);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.ReadOnly = true;
            this.tbNote.Size = new System.Drawing.Size(473, 448);
            this.tbNote.TabIndex = 8;
            // 
            // WatchNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 583);
            this.Controls.Add(this.btnWatchNote);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.lblChooseSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WatchNoteForm";
            this.Text = "Просмотр заметки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChooseSubject;
        private System.Windows.Forms.Button btnWatchNote;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNote;
    }
}