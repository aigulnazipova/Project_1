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
    }
}
