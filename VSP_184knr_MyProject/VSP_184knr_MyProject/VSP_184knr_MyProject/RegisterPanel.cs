using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace VSP_184knr_MyProject
{
    public class RegisterPanel
    {
        private DatabaseHandler databaseHandler;

        public RegisterPanel(DatabaseHandler dbHandler)
        {
            databaseHandler = dbHandler;
        }

        //Проверява дали потербителското име е заето вече.
        public bool IsUsernameTaken(string username)
        {
            //Създава се заявка, която преброява редовете в табл. registered_users, където потребителското име съвпада с предоставеното такова.
            string query = "SELECT COUNT(*) FROM registered_users WHERE Username=@username";
            MySqlParameter[] parameters = { new MySqlParameter("@username", username) };
            int count = Convert.ToInt32(databaseHandler.ExecuteQuery(query, parameters)?.Rows[0][0]);
            
            //Ако броят на редовете е по-голям от нула, връща true, това означава, че вече съществува такова потребителско име в базата данни.
            return count > 0;
        }

        //Този метод върши същата логика като горния, но проверява дали подадения имейл е зает вече.
        public bool IsEmailTaken(string email)
        {
            string query = "SELECT COUNT(*) FROM registered_users WHERE Email=@email";
            MySqlParameter[] parameters = { new MySqlParameter("@email", email) };
            int count = Convert.ToInt32(databaseHandler.ExecuteQuery(query, parameters)?.Rows[0][0]);
            return count > 0;
        }

        public void InsertUserIntoDatabase(string firstName, string lastName, string username, string email, string password)
        {
            //С тази заявка се вмъква, в указаната таблица, запис за новия потребител.
            string query = "INSERT INTO registered_users (Username, Password, Email, First_Name, Last_Name) VALUES (@username, @password, @email, @firstName, @lastName)";
            MySqlParameter[] parameters =
            {       
            new MySqlParameter("@username", username),
            new MySqlParameter("@password", password),
            new MySqlParameter("@email", email),
            new MySqlParameter("@firstName", firstName),
            new MySqlParameter("@lastName", lastName)
            };

            databaseHandler.ExecuteNonQuery(query, parameters);
        }
    }
}
