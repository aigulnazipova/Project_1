using StudentDiary.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDiary
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void studentAccountButton_Click(object sender, EventArgs e)
        {
            StudentAccountForm studentAccountForm = new StudentAccountForm();
            studentAccountForm.Show();
            this.Close();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleStudentForm studentScheduleForm = new ScheduleStudentForm();
            studentScheduleForm.Show();
            this.Close();
        }

        private void btnAboutClass_Click(object sender, EventArgs e)
        {
            AboutClassForm aboutClassForm = new AboutClassForm();
            aboutClassForm.Show();
            this.Close();
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
