using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSP_184knr_MyProject
{
    public class UserOperations
    {
        private readonly WorkoutDatabaseOperations workoutDatabaseOperations;
        private readonly DatabaseHandler databaseHandler;

        public UserOperations()
        {
            workoutDatabaseOperations = new WorkoutDatabaseOperations();
            databaseHandler = new DatabaseHandler();
        }

        //Този метод връща цялото име на потребителя, име и фамилия, взимайки го от базта данни, по зададено потребителско име.
        public string GetUserName(string username)
        {
            string query = "SELECT First_Name, Last_Name FROM Registered_Users WHERE Username = @username";
            MySqlParameter[] parameters =
            {
            new MySqlParameter("@username", username)
            };

            DataTable userData = databaseHandler.ExecuteQuery(query, parameters);

            //Проверява се дали userData не е null, и дали има поне 1 ред във върнатия резултат.
            if (userData != null && userData.Rows.Count > 0)
            {
                //Щом влезнем в проверката, се взимат първото и последното име от първия ред на userData.
                string firstName = userData.Rows[0]["First_Name"].ToString();
                string lastName = userData.Rows[0]["Last_Name"].ToString();

                return $"{firstName} {lastName}";
            }

            //Ако няма резултат се връща празен низ.
            return string.Empty;
        }

        //Методът вмъква запис, в съответната таблица в базата данни, за регистрацията на даден потребител за избрана от него тренировка.
        public void InsertUserRegistration(string username, string workoutType, string dayAndHour)
        {
            string[] parts = dayAndHour.Split(new[] { " at " }, StringSplitOptions.RemoveEmptyEntries);
            string day = parts[0];
            string time = parts[1];

            //Извличане на продължителността на избраната тренировка.
            DataTable workoutDetails = workoutDatabaseOperations.GetWorkoutDetails(workoutType, dayAndHour);

            if (workoutDetails != null && workoutDetails.Rows.Count > 0)
            {
                string duration = workoutDetails.Rows[0]["Duration"].ToString();

                //Заявка за вмъкване на данни в указаната таблица.
                string query = "INSERT INTO Workouts_Registrations(User_ID, Trainer_ID, Activity_ID, Workout_Hour, Workout_Day, Duration) " +
                                "VALUES (@userID, @trainerID, @activityID, @workoutHour, @workoutDay, @duration)";

                //Параметри за заявката.
                MySqlParameter[] parameters =
                {
                new MySqlParameter("@userID", GetUserID(username)),
                new MySqlParameter("@trainerID",  workoutDatabaseOperations.GetTrainerID(workoutType, day, time)),
                new MySqlParameter("@activityID", workoutDatabaseOperations.GetActivityID(workoutType)),
                new MySqlParameter("@workoutHour", $"{time}"),
                new MySqlParameter("@workoutDay", $"{day}"),
                new MySqlParameter("@duration", duration)
                };

                databaseHandler.ExecuteNonQuery(query, parameters);
            }
        }

        //Метод за извлизане на идентификационния номер по подадено потребителско име.
        public int GetUserID(string username)
        {
            string query = "SELECT User_ID FROM Registered_Users WHERE Username = @username";
            MySqlParameter[] parameters =
            {
            new MySqlParameter("@username", username)
            };

            DataTable userData = databaseHandler.ExecuteQuery(query, parameters);

            if (userData != null && userData.Rows.Count > 0)
            {
                return Convert.ToInt32(userData.Rows[0]["User_ID"]);
            }

            return -1;
        }
    }
}
