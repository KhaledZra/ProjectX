namespace GameLogic;

public class EnemyHandler
{
    public static Enemy GetRandomEnemy(int playerLevel)
    {
        List<Enemy> tempEnemies = new();

        tempEnemies.Add(new("Kel’Thuzad", 10, playerLevel));
        tempEnemies.Add(new("Lich King", 10, playerLevel));
        tempEnemies.Add(new("ARCHIMONDE", 10, playerLevel));
        tempEnemies.Add(new("KIL’JAEDEN", 10, playerLevel));
        tempEnemies.Add(new("DEATHWING", 10, playerLevel));

        Random rnd = new Random();
        int r = rnd.Next(tempEnemies.Count);

        return tempEnemies[r];
    }
}