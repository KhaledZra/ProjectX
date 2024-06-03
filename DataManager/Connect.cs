using EvolveDb;
using MySqlConnector;

namespace DataManager;

public class Connect
{
    private static MySqlConnectionStringBuilder MySqlConString = new MySqlConnectionStringBuilder()
    {
        Server = "localhost",
        Database = "world_of_heretics",
        UserID = "root",
        Password = "password",
        Port = 3306,
    };

    public static void RunDbMigrationSetup()
    {
        string location = "db";
        
        // It's okay if this fails and crashes the program. We need the db to be up and running. :)
        var evolve = new Evolve(ConnectToDb())
        {
            Locations = new[] { location },
            IsEraseDisabled = true,
        };

        evolve.Migrate();
    }

    // Input => Output (Lambda Return)
    public static MySqlConnection ConnectToDb() => new MySqlConnection(MySqlConString.ConnectionString);
}