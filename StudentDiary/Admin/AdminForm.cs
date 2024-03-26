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
    }
}
