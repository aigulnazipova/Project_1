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
        
        public static string Login {  get; set; }
        public static string LastName { get; set; }
        public static string FirstName { get; set; }
        public static string Patronymic { get; set; }
        public static string DateBrth { get; set; }
        public static string NumberTel { get; set; }

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
                            NumberTel = reader["phone_number"].ToString();
                            FirstName = reader["first_name"].ToString();
                            LastName = reader["last_name"].ToString();
                            Patronymic = reader["patronymic"].ToString();
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
