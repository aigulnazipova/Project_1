using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace StudentDiary.Student
{
    public partial class WatchNoteForm : Form
    {
        public WatchNoteForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnWatchNote_Click(object sender, EventArgs e)
        {
            string selectedValue = cbSubject.SelectedItem.ToString();
            string connectionString = "server=localhost;port=3306;user=root;password=root;database=studentdiary";
            string query = "SELECT note FROM notes WHERE subject = @Subject";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Subject", selectedValue);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string note = reader["note"].ToString();
                            tbNote.Text = note;
                        }
                        else
                        {
                            tbNote.Text = "Нет заметок к этому предмету.";
                        }
                    }
                }
            }
        }
    }
}
