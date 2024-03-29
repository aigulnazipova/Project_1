using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public string StringConMySql = @"server=localhost;port=3306;username=root;password=root;database=studentdiary";

        public DataTable MySqlReturnData(string query, DataGridView grid)
        {
            try
            {
                using (MySqlConnection myCon = new MySqlConnection(StringConMySql))
                {
                    myCon.Open();
                    if (myCon.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Не удалось установить подключение к базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(query, myCon))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        grid.DataSource = dt;
                        return dt;
                    }
                }
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


    }
}
