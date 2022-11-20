namespace DataManager;
using Dapper;

public class Save
{
    public static void SaveNewToDb<T>(string tableName, T data, string sqlColumns, string sqlValues)
    {
        string sqlCode =
            $"INSERT INTO {tableName} ({sqlColumns}) " +
            $"VALUES ({sqlValues})";

        Connect.ConnectToDb().Execute(sqlCode, data);
    }
    
    // public static T UpdateToDb<T>(string tableName, int id) // update metod för redan skapade spelare
    // {
    //     string sqlCode = $"SELECT * FROM {tableName} WHERE id = {id}";
    //
    //     return Connect.ConnectToDb().Query<T>(sqlCode).First();
    // }
}