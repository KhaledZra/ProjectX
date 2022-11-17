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
    
    public static Enemy GetRandomEnemy(int playerLevel)
    {
        List<Enemy> tempEnemies = new();

        tempEnemies.Add(ReturnScaledEnemy(" the " + "Goblin", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(" the " + "Skeleton", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(" the " + "Orc", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(" the " + "Abo hazan", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(" the " + "Abo Jihad", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(" the " + "Shaytan", playerLevel));
        tempEnemies.Add(ReturnScaledEnemy(" the " + "Jihn", playerLevel));

        Random rnd = new Random();
        int r = rnd.Next(tempEnemies.Count);

        return tempEnemies[r];
    }
}