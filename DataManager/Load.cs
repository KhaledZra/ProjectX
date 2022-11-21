namespace DataManager;
using Dapper;

public class Load
{
    public static int SelectCountSqlTable(string tableName, string columnName) => 
        Connect.ConnectToDb().Query<int>($"SELECT COUNT({tableName}.{columnName}) FROM {tableName};").Max();


    public static string SelectSqlRandomName(string tableName, string columnName)
    {
        Random rnd = new Random();
        int r = rnd.Next(1, SelectCountSqlTable(tableName, columnName)+1); // min 1, max result+1

        string sqlCode = $"SELECT {tableName}.{columnName} FROM {tableName} WHERE id = {r}";

        return Connect.ConnectToDb().Query<string>(sqlCode).First();
    }

    public static List<T> LoadFromDb<T>(string tableName, int id)
    {
        string sqlCode = $"SELECT * FROM {tableName} WHERE {tableName}.id = {id};";
        
        return Connect.ConnectToDb().Query<T>(sqlCode).ToList();
    }
    
    public static List<T> LoadFromDbWhere<T>(string tableName, string whereColumn)
    {
        string sqlCode = $"SELECT * FROM {tableName} WHERE {whereColumn};";

        return Connect.ConnectToDb().Query<T>(sqlCode).ToList();
    }
    
    public static List<T> LoadCharacterItemsFromDb<T>(int characterId)
    {
        string sqlCode = $"SELECT item_id FROM character_to_item WHERE character_id = {characterId};";
        
        List<int> itemIds = Connect.ConnectToDb().Query<int>(sqlCode).ToList();

        List<T> foundItems = new List<T>();
        
        foreach (var currentItemId in itemIds)
        {
            sqlCode = $"SELECT * FROM item WHERE item.id = {currentItemId};";
            foundItems.Add(Connect.ConnectToDb().Query<T>(sqlCode).First());
        }

        return foundItems;
    }
}