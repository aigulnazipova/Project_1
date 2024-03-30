using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentDiary.Student
{
    public partial class AddNoteForm : Form
    {
        public AddNoteForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            string selectedValue = cbSubject.SelectedItem.ToString();
            string textBoxValue = tbNote.Text;

            string connectionString = "server=localhost;port=3306;user=root;password=root;database=studentdiary";
            string query = "INSERT INTO notes (subject, note) VALUES (@Subject, @Note)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Subject", selectedValue);
                    command.Parameters.AddWithValue("@Note", textBoxValue);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Record added successfully");
                }
            }
        }
    }
}
