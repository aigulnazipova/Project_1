using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentDiary.Student
{
    public partial class ScheduleStudentForm : Form
    {
        private DataBase db;
        public ScheduleStudentForm()
        {
            db = new DataBase();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupNumber.SelectedItem != null && cbFaculty.SelectedItem != null && cbWeekDay.SelectedItem != null)
            {
                string selectedGroupNumber = cbGroupNumber.SelectedItem.ToString();
                string selectedFaculty = cbFaculty.SelectedItem.ToString();
                string selectedWeekDay = cbWeekDay.SelectedItem.ToString();
                RefreshDataGridFiltered(selectedGroupNumber, selectedFaculty, selectedWeekDay, dgwStudentScheduleInfo);
            }
        }

        private void cbGroupNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupNumber.SelectedItem != null && cbFaculty.SelectedItem != null && cbWeekDay.SelectedItem != null)
            {
                string selectedGroupNumber = cbGroupNumber.SelectedItem.ToString();
                string selectedFaculty = cbFaculty.SelectedItem.ToString();
                string selectedWeekDay = cbWeekDay.SelectedItem.ToString();
                RefreshDataGridFiltered(selectedGroupNumber, selectedFaculty, selectedWeekDay, dgwStudentScheduleInfo);
            }
        }
        private void cbWeekDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupNumber.SelectedItem != null && cbFaculty.SelectedItem != null && cbWeekDay.SelectedItem != null)
            {
                string selectedGroupNumber = cbGroupNumber.SelectedItem.ToString();
                string selectedFaculty = cbFaculty.SelectedItem.ToString();
                string selectedWeekDay = cbWeekDay.SelectedItem.ToString();
                RefreshDataGridFiltered(selectedGroupNumber, selectedFaculty, selectedWeekDay, dgwStudentScheduleInfo);
            }
        }
        private void CreateColumns()
        {
            dgwStudentScheduleInfo.Columns.Add("id", "ID");
            dgwStudentScheduleInfo.Columns.Add("group_number", "Номер группы");
            dgwStudentScheduleInfo.Columns.Add("faculty", "Направление");
            dgwStudentScheduleInfo.Columns.Add("week_day", "День недели");
            dgwStudentScheduleInfo.Columns.Add("class_number", "Номер пары");
            dgwStudentScheduleInfo.Columns.Add("subject_name", "Предмет");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5));
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
        private void ScheduleStudentForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dgwStudentScheduleInfo);
        }
        private void RefreshDataGridFiltered(string selectedGroupNumber, string selectedFaculty, string selectedWeekDay, DataGridView dgw)
        {
            dgw.Rows.Clear();

            string connectionString = "server=localhost;port=3306;user=root;password=root;database=studentdiary";
            string queryString = $"SELECT * FROM student_schedule WHERE group_number = '{selectedGroupNumber}' AND faculty = '{selectedFaculty}' AND week_day = '{selectedWeekDay}'";

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

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Close();
        }
    }
}
