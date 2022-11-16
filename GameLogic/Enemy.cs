namespace GameLogic;
public class Enemy : Entity
{
    private List<Enemy> enemies = new();

    public Enemy(string name, int currency, int levelScale, Vocation vocation = Vocation.Unassigned) : base(name, vocation, currency)
    {
        LevelStats.Level = levelScale;
    }

    public static List<Enemy> GenerateEnemies(int playerLevel)
    {
        List<Enemy> enemyList = new();

        enemyList.Add(new("Kel’Thuzad", 10, playerLevel));
        enemyList.Add(new("Lich King", 10, playerLevel));
        enemyList.Add(new("ARCHIMONDE", 10, playerLevel));
        enemyList.Add(new("KIL’JAEDEN", 10, playerLevel));
        enemyList.Add(new("DEATHWING", 10, playerLevel));

        return enemyList;
    }

    public static Enemy GenerateEnemy(int size, int playerLevel)
    {
        Random rnd = new Random();
        int r = rnd.Next(size);

        return GenerateEnemies(playerLevel)[r];
    }


}