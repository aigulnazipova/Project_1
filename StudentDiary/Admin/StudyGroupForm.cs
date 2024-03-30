using MySql.Data.MySqlClient;
using StudentDiary.Admin;
using System;
using System.Data;
using System.Windows.Forms;

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
            dgwStudyGroupInfo.CellFormatting += dgwStudyGroupInfo_CellFormatting;
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
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetInt64(5), record.GetString(6), record.GetString(7), record.GetInt32(8));
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

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }
        
        private void dgwStudyGroupInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4) 
            {
                if (e.Value is DateTime)
                {
                    e.Value = ((DateTime)e.Value).ToShortDateString();
                    e.FormattingApplied = true;
                }
            }
        }
        private void deleteRow()
        {
            int index = dgwStudyGroupInfo.CurrentCell.RowIndex;
            dgwStudyGroupInfo.Rows[index].Visible = false;
            if (dgwStudyGroupInfo.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dgwStudyGroupInfo.Rows[index].Cells[6].Value = RowState.Deleted;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRow();

            db.openConnection();
            for (int index = 0; index < dgwStudyGroupInfo.Rows.Count; index++)
            {
                if (dgwStudyGroupInfo.Rows[index].Cells[6].Value != null)
                {
                    var rowState = (RowState)dgwStudyGroupInfo.Rows[index].Cells[6].Value;
                    if (rowState == RowState.Exited)
                        continue;
                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dgwStudyGroupInfo.Rows[index].Cells[0].Value);
                        var deleteQuery = $" DELETE FROM `student_schedule` WHERE id = `{id}`";
                        var command = new MySqlCommand(deleteQuery, db.getConnection());
                        command.ExecuteNonQuery();

                    }
                }
                else
                {
                    MessageBox.Show("Выберите строку!");
                }

            }
            db.closeConnection();
        }
    }
}
