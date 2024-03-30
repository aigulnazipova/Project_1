using StudentDiary.Admin;
using System;
using System.Windows.Forms;

namespace StudentDiary
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminAccountButton_Click(object sender, EventArgs e)
        {
            AdminAccountForm adminAccountForm = new AdminAccountForm();
            adminAccountForm.Show();
            this.Hide();

        }

        private void btnStudyGroup_Click(object sender, EventArgs e)
        {
            StudyGroupForm studyGroupForm = new StudyGroupForm();
            studyGroupForm.Show();
            this.Close();
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnScheduleAdminForm_Click(object sender, EventArgs e)
        {
            ScheduleAdminForm scheduleAdminForm = new ScheduleAdminForm();
            scheduleAdminForm.Show();
            this.Close();
        }

        private void btnGiveGrade_Click(object sender, EventArgs e)
        {
            GiveGradeForm giveGradeForm = new GiveGradeForm();
            giveGradeForm.Show();
            this.Close();
        }
    }
}
