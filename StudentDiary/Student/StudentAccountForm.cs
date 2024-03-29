﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDiary.Student
{
    public partial class StudentAccountForm : Form
    {
        private DataBase db;
        public StudentAccountForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            var db = new DataBase();

            db.openConnection();

            var command = new MySqlCommand("SELECT * FROM student_users", db.getConnection());
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                tbLastName.Text = reader.GetString("last_name");
                tbFirstName.Text = reader.GetString("first_name");
                tbPatronymic.Text = reader.GetString("patronymic");
                tbPhoneNumber.Text = reader.GetInt64("phone_number").ToString();
                tbEmail.Text = reader.GetString("email");
                tbBirthDate.Text = reader.GetDateTime("birth_date").ToString("yyyy-MM-dd") ;
            }
            else
            {
                MessageBox.Show("Нет данных об этом пользователе.");
            }

            db.closeConnection();
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbPatronymic.Text) || string.IsNullOrEmpty(tbBirthDate.Text) || string.IsNullOrEmpty(tbPhoneNumber.Text) || string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Все поля необходимо заполнить", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Изменить личные данные?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var queryUpdateData = $"UPDATE student_users SET last_name='{tbLastName.Text}', first_name='{tbFirstName.Text}', patronymic='{tbPatronymic.Text}', phone_number='{tbPhoneNumber.Text}', birth_date='{tbBirthDate.Text}', email='{tbEmail.Text}'";

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

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
