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
    
    public static void UpdateCharacterInDb<T>(T data)
    {
        //funkar:
        //string sqlCode = $"INSERT INTO {tableName} ({sqlColumns}) VALUES ({sqlValues});"; 
        //test:
        string sqlCode = $"UPDATE `character` SET `experience` = @Experience, `health` = @MaxHp, `gold` = @Currency, `positionx` = @PositionX, `positiony` = @PositionY  WHERE `character`.`id` = @Id;";
        
        Connect.ConnectToDb().Execute(sqlCode, data);
    }

    public static void SaveCharacterToItemInDb<T>(T data, string sqlValues)
    {
        string sqlCode = $"INSERT INTO character_to_item (character_id, item_id) VALUES ({sqlValues});";
        
        Connect.ConnectToDb().Execute(sqlCode, data);
    }
    
    public static void DeleteFromCharacterToItemInDb<T>(T data)
    {
        string sqlCode = $"DELETE FROM character_to_item WHERE item_id = @ItemId AND character_id = @CharacterId;";
        
        Connect.ConnectToDb().Execute(sqlCode, data);
    }
}
