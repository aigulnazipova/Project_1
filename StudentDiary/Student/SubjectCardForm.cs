using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace StudentDiary.Student
{
    public partial class SubjectCardForm : Form
    {
        public SubjectCardForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            var db = new DataBase();

            
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Close();
        }

    }
}
