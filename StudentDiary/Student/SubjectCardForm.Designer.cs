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
            this.pbAboutClass = new System.Windows.Forms.PictureBox();
            this.btnReturnBack = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.dgwAboutClasses = new System.Windows.Forms.DataGridView();
            this.btnWatchNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAboutClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAboutClass
            // 
            this.pbAboutClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            this.pbAboutClass.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutClass.Image")));
            this.pbAboutClass.Location = new System.Drawing.Point(357, 43);
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
            this.btnReturnBack.Location = new System.Drawing.Point(1056, 2);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(94, 34);
            this.btnReturnBack.TabIndex = 16;
            this.btnReturnBack.Text = "Назад";
            this.btnReturnBack.UseVisualStyleBackColor = false;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddNote.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddNote.Location = new System.Drawing.Point(252, 131);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(319, 44);
            this.btnAddNote.TabIndex = 17;
            this.btnAddNote.Text = "Добавить заметку";
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // dgwAboutClasses
            // 
            this.dgwAboutClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwAboutClasses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwAboutClasses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwAboutClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAboutClasses.Location = new System.Drawing.Point(84, 193);
            this.dgwAboutClasses.Name = "dgwAboutClasses";
            this.dgwAboutClasses.RowHeadersWidth = 51;
            this.dgwAboutClasses.RowTemplate.Height = 24;
            this.dgwAboutClasses.Size = new System.Drawing.Size(984, 418);
            this.dgwAboutClasses.TabIndex = 18;
            // 
            // btnWatchNote
            // 
            this.btnWatchNote.BackColor = System.Drawing.Color.RosyBrown;
            this.btnWatchNote.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWatchNote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWatchNote.Location = new System.Drawing.Point(590, 131);
            this.btnWatchNote.Name = "btnWatchNote";
            this.btnWatchNote.Size = new System.Drawing.Size(319, 44);
            this.btnWatchNote.TabIndex = 19;
            this.btnWatchNote.Text = "Просмотреть заметку";
            this.btnWatchNote.UseVisualStyleBackColor = false;
            this.btnWatchNote.Click += new System.EventHandler(this.btnWatchNote_Click);
            // 
            // SubjectCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 637);
            this.Controls.Add(this.btnWatchNote);
            this.Controls.Add(this.dgwAboutClasses);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.btnReturnBack);
            this.Controls.Add(this.pbAboutClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SubjectCardForm";
            this.Load += new System.EventHandler(this.SubjectCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAboutClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbAboutClass;
        private System.Windows.Forms.Button btnReturnBack;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.DataGridView dgwAboutClasses;
        private System.Windows.Forms.Button btnWatchNote;
    }
}