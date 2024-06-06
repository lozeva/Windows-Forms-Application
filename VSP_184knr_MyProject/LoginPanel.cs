using MySql.Data.MySqlClient;
using System;
using System.Data;
using BCrypt.Net;
using System.Text;

namespace VSP_184knr_MyProject
{
    public class LoginPanel
    {
        private DatabaseHandler databaseHandler;

        //Този конструктор има параметър от тип DatabaseHandler.
        public LoginPanel(DatabaseHandler dbHandler)
        {
            //Тук, променливата databaseHandler примеа стойността на параметъра.
            databaseHandler = dbHandler;
        }

        //В този метод се прави валидация за вход в системата.
        public bool IsValidLogin(string username, string password)
        {
            string query = "SELECT * FROM registered_users WHERE Username=@username AND Password=@password";
            
            //Този масив от обекти, задава стойностите за username и password.
            MySqlParameter[] parameters =
            {
            new MySqlParameter("@username", username),

            //Тук, паролата първо се хешира, чрез метода HashPassword, и после се добавя към параметрите.
            new MySqlParameter("@password", HashPassword(password))
            };

            //Методът ExecuteQuery се извиква, за да изпълни SQL заявката с предоставените параметри.
            DataTable dt = databaseHandler.ExecuteQuery(query, parameters);

            //Проверява се дали променливата dt има един или повече реда, ако е така методът връща true,
            // тоест входът в системата е валиден.
            return dt?.Rows.Count > 0;
        }

        //Метод за хеширане на парола.
        private string HashPassword(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(passwordBytes);
        }
    }
}
