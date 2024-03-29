using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDiary.Student
{
    public partial class AboutClassForm : Form
    {
        public AboutClassForm()
        {
            InitializeComponent();
        }
        
        private void AboutClassForm_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; port=3306; username=root; password=root; database=studentdiary";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT subject_name AS 'Предмет', format AS 'Формат', info AS 'О занятии' FROM about_classes", mysqlCon);
                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);
                dgwAboutClassesInfo.DataSource = dataTable;
            }
        }
    }
}
