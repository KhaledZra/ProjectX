namespace GameLogic;

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
        List<Enemy> tempEnemies = new();

        tempEnemies.Add(ReturnScaledEnemy(GetEnemyName() + " the " + "Goblin", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(GetEnemyName() + " the " + "Skeleton", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(GetEnemyName() + " the " + "Orc", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(GetEnemyName() + " the " + "Abo hazan", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(GetEnemyName() + " the " + "Abo Jihad", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(GetEnemyName() + " the " + "Shaytan", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(GetEnemyName() + " the " + "Jihn", playerLevel));

        return tempEnemies[RandomizeInt(tempEnemies.Count)];
    }
    
    public static string GetEnemyName()
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
    }
}