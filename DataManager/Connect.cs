using Dapper;
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
    private static MySqlConnection ConnectToDb() => new MySqlConnection(MySqlConString.ConnectionString);

    private static int SelectCountSqlTable(string tableName, string columnName) => 
        ConnectToDb().Query<int>($"SELECT COUNT({tableName}.{columnName}) FROM {tableName};").Max();


    public static string SelectSqlRandomName(string tableName, string columnName)
    {
        Random rnd = new Random();
        int r = rnd.Next(1, SelectCountSqlTable(tableName, columnName)+1); // min 1, max result+1

        string sqlCode = $"SELECT {tableName}.{columnName} FROM {tableName} WHERE id = {r}";

        return ConnectToDb().Query<string>(sqlCode).First();
    }
    
}