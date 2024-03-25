using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    internal class PersonalData
    {
        public static int IdUser { get; private set; }
        public static string Password { get; private set; }
        public static string Login { get; private set; }
        public static string LastName { get; private set; }
        public static string FirstName { get; private set; }
        public static string FatherName { get; private set; }
        public static string DateBrth { get; private set; }
        public static string NumberTel { get; private set; }

        public bool SetPersonalData(string login, string password)
        {
            var db = new DataBase();

            string query = "SELECT * FROM `admin_users` a INNER JOIN `users` u ON a.id_user = u.id WHERE u.login = @Login AND u.password = @Password LIMIT 1";

            using (MySqlConnection connection = db.getConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IdUser = Convert.ToInt32(reader["id_user"]);
                            Login = reader["login"].ToString();
                            Password = reader["password"].ToString();
                            NumberTel = reader["phone_number"].ToString();
                            FirstName = reader["first_name"].ToString();
                            LastName = reader["last_name"].ToString();
                            FatherName = reader["patronymic"].ToString();
                            DateBrth = reader.GetDateTime(reader.GetOrdinal("birth_date")).ToString("yyyy-MM-dd");
                            return true;
                        }
                    }
                    return false;
                }
            }
        }
    }
}
