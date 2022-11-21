namespace DataManager;

using Dapper;

public class Save
{
    public static void SaveNewToDb<T>(string tableName, T data, string sqlColumns, string sqlValues)
    {
        string sqlCode =
            $"INSERT INTO {tableName} ({sqlColumns}) " +
            $"VALUES ({sqlValues});";

        Connect.ConnectToDb().Execute(sqlCode, data);
    }
    //SKRÄP
    /*public static void UpdateCharacterInDb<T>(string tableName, T data, string sqlColumns, string sqlValues)
    {
        /*string sqlCode = $"INSERT INTO {tableName} ({sqlColumns}, {sqlColumns}, {sqlColumns}, {sqlColumns}, {sqlColumns})" +
                       $"VALUES(@Experience, @MaxHp, @Currency, @PositionX, @PositionY)";#1#
        string sqlCode = $"UPDATE {tableName} SET ({sqlColumns},{sqlColumns},{sqlColumns},{sqlColumns},{sqlColumns}) VALUES {sqlValues} WHERE id = @Id;";

        Connect.ConnectToDb().Execute(sqlCode, data);
    }*/
    public static void UpdateCharacterInDb<T>(string tableName, T data, string sqlColumns, string sqlValues)
    {
        //funkar:
        //string sqlCode = $"INSERT INTO {tableName} ({sqlColumns}) VALUES ({sqlValues});"; 
        //test:
        string sqlCode = $"UPDATE `character` SET `experience` = @Experience, `health` = @MaxHp, `gold` = @Currency, `positionx` = @PositionX, `positiony` = @PositionY  WHERE `character`.`id` = @Id;";
        
        Connect.ConnectToDb().Execute(sqlCode, data);
    }
}
