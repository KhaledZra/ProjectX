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
        return ReturnScaledEnemy(Load.SelectSqlRandomName("enemy_name", "name") + " the " +
                                 Load.SelectSqlRandomName("enemy_race", "name"), playerLevel);
    }
}