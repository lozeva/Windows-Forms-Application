using MySql.Data.MySqlClient;
using System.Data;

public class DatabaseHandler
{
    private readonly MySqlConnection connection;
    //TODO: reset credentials!!!!! 
    private const string username = "root";
    private const string pass = "1234";
    private const string dbName = "MyFitnessApp";
    private const string connectionString = "server=localhost;user=" + username + ";database=" + dbName + ";password=" + pass;

    public DatabaseHandler()
    {
        connection = new MySqlConnection(connectionString);
    }

    public static string GetConnectionString() {
        return connectionString;
    }

    public void OpenConnection()
    {
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }

    //Този метод изпълнява MySQL заявка към базата данни, след това отваря връзка с базата данни, създава
    //команда с предоставената заявка и параметри и попълва DataTable с резултатите чрез data adapter, след което връща попълнената DataTable. 
    public DataTable ExecuteQuery(string query, MySqlParameter[] parameters)
    {
        try
        {
            OpenConnection();

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                //MySqlDataAdapter е обект, който се използва за извличане на данни от базата данни.
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
            return null;
        }
        //Този блок затваря връзката, без значение дали се е появила грешка, или не по време на изпълнението на горния код от try и catch.
        finally
        {
            CloseConnection();
        }
    }

    //В този блок от код, се изпълнява заявка за промяна в базата данни: update, insert, delete.
    //Като се връща броя на засегнатите редове.
    public int ExecuteNonQuery(string query, MySqlParameter[] parameters)
    {
        try
        {
            OpenConnection();

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
            return -1;
        }
        finally
        {
            CloseConnection();
        }
    }
}