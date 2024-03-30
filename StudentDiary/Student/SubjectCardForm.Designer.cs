namespace StudentDiary.Student
{
    partial class SubjectCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectCardForm));
            this.tb_note = new System.Windows.Forms.RichTextBox();
            this.pbAboutClass = new System.Windows.Forms.PictureBox();
            this.btnReturnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutClass)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(12, 181);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(735, 455);
            this.tb_note.TabIndex = 0;
            this.tb_note.Text = "";
            // 
            // pbAboutClass
            // 
            this.pbAboutClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.pbAboutClass.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutClass.Image")));
            this.pbAboutClass.Location = new System.Drawing.Point(150, 43);
            this.pbAboutClass.Name = "pbAboutClass";
            this.pbAboutClass.Size = new System.Drawing.Size(458, 72);
            this.pbAboutClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAboutClass.TabIndex = 1;
            this.pbAboutClass.TabStop = false;
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnReturnBack.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReturnBack.Location = new System.Drawing.Point(665, 4);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(94, 34);
            this.btnReturnBack.TabIndex = 16;
            this.btnReturnBack.Text = "Назад";
            this.btnReturnBack.UseVisualStyleBackColor = false;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(220, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить заметку";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SubjectCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturnBack);
            this.Controls.Add(this.pbAboutClass);
            this.Controls.Add(this.tb_note);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SubjectCardForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_note;
        private System.Windows.Forms.PictureBox pbAboutClass;
        private System.Windows.Forms.Button btnReturnBack;
        private System.Windows.Forms.Button button1;
    }
}