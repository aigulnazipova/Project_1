using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentDiary.Admin
{
    enum RowState
    {
        Exited,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class ScheduleAdminForm : Form
    {
        private DataBase db;
        public ScheduleAdminForm()
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
                RefreshDataGridFiltered(selectedGroupNumber, selectedFaculty, selectedWeekDay, dgwAdminScheduleInfo);
            }
        }

        private void cbGroupNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupNumber.SelectedItem != null && cbFaculty.SelectedItem != null && cbWeekDay.SelectedItem != null)
            {
                string selectedGroupNumber = cbGroupNumber.SelectedItem.ToString();
                string selectedFaculty = cbFaculty.SelectedItem.ToString();
                string selectedWeekDay = cbWeekDay.SelectedItem.ToString();
                RefreshDataGridFiltered(selectedGroupNumber, selectedFaculty, selectedWeekDay, dgwAdminScheduleInfo);
            }
        }
        private void cbWeekDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupNumber.SelectedItem != null && cbFaculty.SelectedItem != null && cbWeekDay.SelectedItem != null)
            {
                string selectedGroupNumber = cbGroupNumber.SelectedItem.ToString();
                string selectedFaculty = cbFaculty.SelectedItem.ToString();
                string selectedWeekDay = cbWeekDay.SelectedItem.ToString();
                RefreshDataGridFiltered(selectedGroupNumber, selectedFaculty, selectedWeekDay, dgwAdminScheduleInfo);
            }
        }
        private void CreateColumns()
        {
            dgwAdminScheduleInfo.Columns.Add("id", "ID");
            dgwAdminScheduleInfo.Columns.Add("group_number", "Номер группы");
            dgwAdminScheduleInfo.Columns.Add("faculty", "Направление");
            dgwAdminScheduleInfo.Columns.Add("week_day", "День недели");
            dgwAdminScheduleInfo.Columns.Add("class_number", "Номер пары");
            dgwAdminScheduleInfo.Columns.Add("subject_name", "Предмет");
            dgwAdminScheduleInfo.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5), RowState.ModifiedNew);
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
        private void RefreshDataGridFiltered(string selectedGroupNumber, string selectedFaculty, string selectedWeekDay, DataGridView dgw)
        {
            dgw.Rows.Clear();

            string connectionString = "server=localhost;port=3306;user=root;password=root;database=studentdiary";
            string queryString = $"SELECT * FROM student_schedule WHERE group_number = '{selectedGroupNumber}' AND faculty = '{selectedFaculty}'";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.openConnection();

            
            int group_number;
            if (!int.TryParse(tbGroupNumber.Text, out group_number))
            {
                MessageBox.Show("Некорректный формат! Введите число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
                return;
            }
            var faculty = tbFaculty.Text;
            var week_day = tbWeekDay.Text;
            int class_number;
            if (!int.TryParse(tbClassNumber.Text, out class_number))
            {
                MessageBox.Show("Некорректный формат! Введите число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
                return;
            }
            var subject_name = tbSubject.Text;
            var format = tbFormat.Text;

            string queryString = "INSERT INTO student_schedule (group_number, faculty, week_day, class_number, subject_name, format) VALUES (@group_number, @faculty, @week_day, @class_number, @subject_name, @format)";
            MySqlCommand command = new MySqlCommand(queryString, db.getConnection());
            command.Parameters.Add("@group_number", MySqlDbType.Int32).Value = group_number;
            command.Parameters.Add("@faculty", MySqlDbType.VarChar).Value = faculty;
            command.Parameters.Add("@week_day", MySqlDbType.VarChar).Value = week_day;
            command.Parameters.Add("@class_number", MySqlDbType.Int32).Value = class_number;
            command.Parameters.Add("@subject_name", MySqlDbType.VarChar).Value = subject_name;
            command.Parameters.Add("@format", MySqlDbType.VarChar).Value = format;

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании записи: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();

        }

        private void deleteRow()
        {
            int index = dgwAdminScheduleInfo.CurrentCell.RowIndex;
            dgwAdminScheduleInfo.Rows[index].Visible = false;
            if (dgwAdminScheduleInfo.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dgwAdminScheduleInfo.Rows[index].Cells[6].Value = RowState.Deleted;
            } 

        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            deleteRow();

            db.openConnection();
            for (int index = 0; index < dgwAdminScheduleInfo.Rows.Count; index++)
            {
                var rowState = (RowState)dgwAdminScheduleInfo.Rows[index].Cells[6].Value;
                if (rowState == RowState.Exited)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dgwAdminScheduleInfo.Rows[index].Cells[0].Value);
                    var deleteQuery = $" DELETE FROM `student_schedule` WHERE id = `{id}`";
                    var command = new MySqlCommand(deleteQuery, db.getConnection());
                    command.ExecuteNonQuery();

                }
            }
            db.closeConnection();
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }
    }
}
