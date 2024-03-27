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
    public partial class AddStudentForm : Form
    {
        private DataBase db;
        public AddStudentForm()
        {
            db = new DataBase();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.getConnection();

            var last_name = tbLastName.Text;
            var first_name = tbFirstName.Text;
            var patronymic = tbPatronymic.Text;
            DateTime birth_Date;
            if (!DateTime.TryParse(tbBirthDate.Text, out birth_Date))
            {
                MessageBox.Show("Некорректный формат даты рождения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
                return;
            }
            int phone_number;
            if (!int.TryParse(tbPhoneNumber.Text, out phone_number))
            {
                MessageBox.Show("Номер телефона должен быть числом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
                return;
            }

            var email = tbEmail.Text;
            var faculty = tbFaculty.Text;
            int group_number;
            if (!int.TryParse(tbGroupNumber.Text, out group_number))
            {
                MessageBox.Show("Номер группы должен быть числом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
                return;
            }
            string connectionString = "server=localhost;port=3306;user=root;password=root;database=studentdiary";
            string queryString = "INSERT INTO student_users (last_name, first_name, patronymic, birth_date, phone_number, email, faculty, group_number) VALUES (@last_name, @first_name, @patronymic, @birth_date, @phone_number, @email, @faculty, @group_number)";
            MySqlCommand command = new MySqlCommand(queryString, db.getConnection());
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = last_name;
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = first_name;
            command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = patronymic;
            command.Parameters.Add("@birth_Date", MySqlDbType.Date).Value = birth_Date;
            command.Parameters.Add("@phone_number", MySqlDbType.Int32).Value = phone_number;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@faculty", MySqlDbType.VarChar).Value = faculty;
            command.Parameters.Add("@group_number", MySqlDbType.Int32).Value = group_number;


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

    }

}

