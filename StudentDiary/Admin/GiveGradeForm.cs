using System;
using System.Windows.Forms;

namespace StudentDiary.Admin
{
    public partial class GiveGradeForm : Form
    {
        public GiveGradeForm()
        {
            InitializeComponent();
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }
    }
}
