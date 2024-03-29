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

namespace StudentDiary.Admin
{
    public partial class ScheduleAdminForm : Form
    {
        private DataBase db;
        public ScheduleAdminForm()
        {
            db = new DataBase();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dgwAdminScheduleInfo.Columns.Add("group_number", "Номер группы");
            dgwAdminScheduleInfo.Columns.Add("faculty", "Направление");
            dgwAdminScheduleInfo.Columns.Add("week_day", "День недели");
            dgwAdminScheduleInfo.Columns.Add("class_number", "Номер пары");
            dgwAdminScheduleInfo.Columns.Add("subject", "Предмет");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string connectionString = "server=localhost;port=3306;user=root;password=root;database=studentdiary";
            string queryString = "SELECT * FROM student_schedule";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReadSingleRow(dgw, reader);
                        }
                    }
                }
            }
        }


        private void ScheduleAdminForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dgwAdminScheduleInfo);
        }
    }
}
