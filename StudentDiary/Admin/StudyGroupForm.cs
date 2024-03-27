using MySql.Data.MySqlClient;
using StudentDiary.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDiary
{
    public partial class StudyGroupForm : Form
    {
        private DataBase db;
        public StudyGroupForm()
        {
            db = new DataBase();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnCloseStudyGroupForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM student_users";
            if (db.MySqlReturnData(query, dgwStudyGroupInfo) != null)
            {
                MessageBox.Show("Запрос успешно выполнен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CreateColumns()
        {
            dgwStudyGroupInfo.Columns.Add("id", "ID");
            dgwStudyGroupInfo.Columns.Add("last_name", "Фамилия");
            dgwStudyGroupInfo.Columns.Add("first_name", "Имя");
            dgwStudyGroupInfo.Columns.Add("patronymic", "Отчество");
            dgwStudyGroupInfo.Columns.Add("birth_date", "Дата рождения");
            dgwStudyGroupInfo.Columns.Add("phone_number", "Номер телефона");
            dgwStudyGroupInfo.Columns.Add("email", "Почта");
            dgwStudyGroupInfo.Columns.Add("faculty", "Направление");
            dgwStudyGroupInfo.Columns.Add("group_number", "Номер группы");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetInt32(5), record.GetString(6), record.GetString(7), record.GetInt32(8));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string connectionString = "server=localhost;port=3306;user=root;password=root;database=studentdiary";
            string queryString = "SELECT * FROM student_users";

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
        private void StudyGroupForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dgwStudyGroupInfo);
        }

        private void RefreshDataGridFiltered(string selectedGroupNumber, string selectedFaculty, DataGridView dgw)
        {
            dgw.Rows.Clear();

            string connectionString = "server=localhost;port=3306;user=root;password=root;database=studentdiary";
            string queryString = $"SELECT * FROM student_users WHERE group_number = '{selectedGroupNumber}' AND faculty = '{selectedFaculty}'";

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
        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupNumber.SelectedItem != null && cbFaculty.SelectedItem != null)
            {
                string selectedGroupNumber = cbGroupNumber.SelectedItem.ToString();
                string selectedFaculty = cbFaculty.SelectedItem.ToString();
                RefreshDataGridFiltered(selectedGroupNumber, selectedFaculty, dgwStudyGroupInfo);
            }        
        }

        private void cbGroupNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupNumber.SelectedItem != null && cbFaculty.SelectedItem != null)
            {
                string selectedGroupNumber = cbGroupNumber.SelectedItem.ToString();
                string selectedFaculty = cbFaculty.SelectedItem.ToString();
                RefreshDataGridFiltered(selectedGroupNumber, selectedFaculty, dgwStudyGroupInfo);
            }
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }
    }
}
