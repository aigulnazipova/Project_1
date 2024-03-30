﻿namespace StudentDiary.Student
{
    partial class AddNoteForm
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
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lblChooseSubject = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNote
            // 
            this.tbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNote.Location = new System.Drawing.Point(3, 80);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(473, 448);
            this.tbNote.TabIndex = 0;
            // 
            // lblChooseSubject
            // 
            this.lblChooseSubject.AutoSize = true;
            this.lblChooseSubject.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseSubject.Location = new System.Drawing.Point(127, 18);
            this.lblChooseSubject.Name = "lblChooseSubject";
            this.lblChooseSubject.Size = new System.Drawing.Size(217, 29);
            this.lblChooseSubject.TabIndex = 3;
            this.lblChooseSubject.Text = "Выберите предмет";
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
            this.cbSubject.Location = new System.Drawing.Point(141, 50);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(189, 24);
            this.cbSubject.TabIndex = 4;
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddNote.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddNote.Location = new System.Drawing.Point(159, 534);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(159, 37);
            this.btnAddNote.TabIndex = 5;
            this.btnAddNote.Text = "Сохранить";
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 583);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.lblChooseSubject);
            this.Controls.Add(this.tbNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNoteForm";
            this.Text = "Добавить заметку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lblChooseSubject;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Button btnAddNote;
    }
}