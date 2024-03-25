using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDiary
{
    internal class DataBase
    {
        public MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=studentdiary");

        public MySqlDataAdapter Execute(string query)
        {
            try
            {
                connection.Open();
                if (connection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Не удалось установить подключение к базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                MySqlDataAdapter mda = new MySqlDataAdapter(query, connection);
                mda.SelectCommand.ExecuteNonQuery();
                return mda;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Возникла ошибка при выполнении запроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }


    }
}
