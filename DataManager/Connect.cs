using MySqlConnector;

namespace DataManager;

public class Connect
{
    private static MySqlConnectionStringBuilder MySqlConString = new MySqlConnectionStringBuilder()
    {
        Server = "localhost",
        Database = "world_of_heretics",
        UserID = "root",
    };

    // Input => Output (Lambda Return)
    public static MySqlConnection ConnectToDb() => new MySqlConnection(MySqlConString.ConnectionString);
}