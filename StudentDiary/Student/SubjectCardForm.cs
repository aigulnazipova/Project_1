using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentDiary.Student
{
    public partial class SubjectCardForm : Form
    {
        public SubjectCardForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            var db = new DataBase();
            
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Close();
        }
        private void CreateColumns()
        {
            dgwAboutClasses.Columns.Add("id", "ID");
            dgwAboutClasses.Columns.Add("subject_name", "Предмет");
            dgwAboutClasses.Columns.Add("format", "Формат");
            dgwAboutClasses.Columns.Add("info", "Информация");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string connectionString = "server=localhost;port=3306;user=root;password=root;database=studentdiary";
            string queryString = "SELECT * FROM about_classes";

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
        private void SubjectCardForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dgwAboutClasses);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            AddNoteForm addNoteForm = new AddNoteForm();
            addNoteForm.Show();
        }

        private void btnWatchNote_Click(object sender, EventArgs e)
        {
            
        }
    }
}
