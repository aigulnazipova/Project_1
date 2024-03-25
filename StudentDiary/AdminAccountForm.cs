using MySql.Data.MySqlClient;
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
using System.Xml.Linq;

namespace StudentDiary
{
    public partial class AdminAccountForm : Form
    {
        private DataBase db;
        public AdminAccountForm()
        {
            db = new DataBase();
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminAccountForm_Load(object sender, EventArgs e)
        {
            LoadPersonalData();
        }

        private void LoadPersonalData()
        {
            btnLastName.Text = PersonalData.LastName;
            btnFirstName.Text = PersonalData.FirstName;
            btnPatronymic.Text = PersonalData.FatherName;
            btnBirthDate.Text = PersonalData.DateBrth;
            btnPhoneNumber.Text = PersonalData.NumberTel;
            btnEmail.Text = PersonalData.Login;
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btnLastName.Text) || string.IsNullOrEmpty(btnFirstName.Text) || string.IsNullOrEmpty(btnPatronymic.Text) || string.IsNullOrEmpty(btnBirthDate.Text) || string.IsNullOrEmpty(btnPhoneNumber.Text) || string.IsNullOrEmpty(btnBirthDate.Text) || string.IsNullOrEmpty(btnEmail.Text))
            {
                MessageBox.Show("Все поля необходимо заполнить", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Изменить личные данные?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var queryUpdateData = $"UPDATE admin_users a " +
                      $"SET last_name='{btnLastName.Text}', first_name='{btnFirstName.Text}', patronymic='{btnPatronymic.Text}', phone_number='{btnPhoneNumber.Text}', birth_date='{btnBirthDate.Text}' " +
                      $"WHERE last_name='{PersonalData.FirstName}' AND first_name='{PersonalData.LastName}' AND patronymic='{PersonalData.FatherName}' " +
                      $"AND phone_number='{PersonalData.NumberTel}' AND birth_date='{PersonalData.DateBrth}'";

                if (db.Execute(queryUpdateData) != null)
                {
                    MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Действие было отменено!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
