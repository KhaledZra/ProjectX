namespace GameLogic;

using DataManager;

public class EnemyHandler
{
    private static Enemy ReturnScaledEnemy(string enemyName, int playerLevel)
    {
        Enemy tempEnemy = new Enemy(enemyName);

        float scaler = (float)playerLevel / 2.0f;

        float fHealth = tempEnemy.Health * scaler;
        float fCurrency = tempEnemy.Currency * scaler;
        float fExperience = 100 * scaler;

        tempEnemy.Health = (int)fHealth;
        tempEnemy.Currency = (int)fCurrency;
        tempEnemy.LevelStats.Level = playerLevel;
        tempEnemy.LevelStats.Experience = (int)fExperience;

        return tempEnemy;
    }

    private static int RandomizeInt(int maxValue)
    {
        Random rnd = new Random();
        return rnd.Next(maxValue);
    }

    public static Enemy GetRandomEnemy(int playerLevel)
    {
        return ReturnScaledEnemy(Load.SelectSqlRandomName("enemy_name","name") + " the " + 
                                 Load.SelectSqlRandomName("enemy_race","name"), playerLevel);
    }
    /*public string SelectSqlRandomName(string tableName, string columnName)
    {
        Random rnd = new Random();
        int r = rnd.Next(1, SelectCountSqlTable(tableName, columnName)+1); // min 1, max result+1

        string sqlCode = $"SELECT {tableName}.{columnName} FROM {tableName} WHERE id = {r}";

        return ConnectToDb().Query<string>(sqlCode).First();
    }*/
    /*public static string GetEnemyName()
    {
        List<string> enemyNames = new List<string>();
        
        enemyNames.Add("Abo Hazan");
        enemyNames.Add("Az-Adar");
        enemyNames.Add("Azog");
        enemyNames.Add("Gorbag");
        enemyNames.Add("Gothmog");
        enemyNames.Add("Grishnákh");
        enemyNames.Add("Kâka");
        enemyNames.Add("Shag");
        enemyNames.Add("Shagrat");
        enemyNames.Add("Skak");
        enemyNames.Add("Snaga");
        enemyNames.Add("Uglúk");
        enemyNames.Add("Shaká");
        enemyNames.Add("Zuka");
        enemyNames.Add("Ogg");
        
        return enemyNames[RandomizeInt(enemyNames.Count)];
    }*/
}