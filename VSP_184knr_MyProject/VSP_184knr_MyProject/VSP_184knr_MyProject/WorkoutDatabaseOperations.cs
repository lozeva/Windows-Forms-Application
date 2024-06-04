using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSP_184knr_MyProject
{
    public class WorkoutDatabaseOperations
    {
        private readonly DatabaseHandler databaseHandler;

        public WorkoutDatabaseOperations()
        {
            databaseHandler = new DatabaseHandler();
        }

        //Извличане на графика за тренировки от БД.
        public DataTable GetWorkoutScheduleFromDatabase(string workoutType)
        {
            //Извличане на деня и началния час за даден вид тренировка от табл. Schedule. Като също така се прави и извличане на 
            //идентификационния номер на тренировката от табл. Activities.
            string query = "SELECT DISTINCT Day_of_Week, Start_Time FROM Schedule " +
                           "WHERE Activity_ID = (SELECT ID_Activity FROM Activities WHERE Name_Activity = @workoutType)";

            MySqlParameter[] parameters =
            {
            new MySqlParameter("@workoutType", workoutType)
            };

            DataTable res = databaseHandler.ExecuteQuery(query, parameters);
            return res;
        }

        public DataTable GetWorkoutDetails(string workoutType, string dayAndHour)
        {
            //Извличане на ден и час.
            string[] parts = dayAndHour.Split(new[] { " at " }, StringSplitOptions.RemoveEmptyEntries);
            string day = parts[0];
            string time = parts[1];

            //Чрез тази заявка се извличат детайли за тренировката: всички колони от табл. Schedule, също и Name_Activity от табл. Activities.
            string query = "SELECT Schedule.*, Activities.Name_Activity " +
                            "FROM Schedule " +
                            "JOIN Activities ON Schedule.Activity_ID = Activities.ID_Activity " +
                            "WHERE Activities.Name_Activity = @workoutType AND Day_of_Week = @day AND Start_Time = @time";

            MySqlParameter[] parameters =
            {
            new MySqlParameter("@workoutType", workoutType),
            new MySqlParameter("@day", day),
            new MySqlParameter("@time", time)
            };

            return databaseHandler.ExecuteQuery(query, parameters);
        }

        //Метод за извличане на детайли за треньора, който провежда дадена тренировка в определен час, от БД.
        public DataTable GetTrainerDetails(string workoutType, string dayAndHour)
        {
            string[] parts = dayAndHour.Split(new[] { " at " }, StringSplitOptions.RemoveEmptyEntries);
            string day = parts[0];
            string time = parts[1];

            //Заявката извлича името на треньора от табл. Trainers.
            string query = "SELECT Trainer_Name FROM Trainers " +
                            "WHERE Trainer_ID = (SELECT Trainer_ID FROM Schedule " +
                            "WHERE Activity_ID = (SELECT ID_Activity FROM Activities WHERE Name_Activity = @workoutType) " +
                            "AND Day_of_Week = @day AND Start_Time = @time)";

            MySqlParameter[] parameters =
            {
            new MySqlParameter("@workoutType", workoutType),
            new MySqlParameter("@day", day),
            new MySqlParameter("@time", time)
            };

            return databaseHandler.ExecuteQuery(query, parameters);
        }

        //Чрез този метод се извлича идентификационния номер на дейността.
        public int GetActivityID(string workoutType)
        {
            string query = "SELECT ID_Activity FROM Activities WHERE Name_Activity = @workoutType";
            MySqlParameter[] parameters =
            {
            new MySqlParameter("@workoutType", workoutType)
            };

            DataTable activityData = databaseHandler.ExecuteQuery(query, parameters);

            //Ако резултата не е null и има поне 1 ред в резултатната таблица, се връща стойността на ID_Activity от първия ред.
            if (activityData != null && activityData.Rows.Count > 0)
            {
                return Convert.ToInt32(activityData.Rows[0]["ID_Activity"]);
            }

            return -1;
        }

        public int GetTrainerID(string workoutType, string day, string time)
        {
            //Тази заявка извлича ID-то на треньора от табл. Schedule, където са изпулнени условията за деня, часа и типа на тренировката.
            string query = "SELECT Trainer_ID FROM Schedule " +
                           "WHERE Activity_ID = (SELECT ID_Activity FROM Activities WHERE Name_Activity = @workoutType) " +
                           "AND Day_of_Week = @day AND Start_Time = @time";

            MySqlParameter[] parameters =
            {
            new MySqlParameter("@workoutType", workoutType),
            new MySqlParameter("@day", day),
            new MySqlParameter("@time", time)
            };

            DataTable trainerData = databaseHandler.ExecuteQuery(query, parameters);

            if (trainerData != null && trainerData.Rows.Count > 0)
            {
                return Convert.ToInt32(trainerData.Rows[0]["Trainer_ID"]);
            }

            return -1;
        }  
    }
}
