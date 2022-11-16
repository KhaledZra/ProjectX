namespace GameLogic;
public class Enemy : Entity
{
    private List<Enemy> enemies = new();

    public Enemy(string name, int currency, Vocation vocation = Vocation.Unassigned) : base(name, vocation, currency)
    {

    }

    public static List<Enemy> GenerateEnemies()
    {
        List<Enemy> enemyList = new();

        enemyList.Add(new("Kel’Thuzad", 10));
        enemyList.Add(new("Lich King", 10));
        enemyList.Add(new("ARCHIMONDE", 10));
        enemyList.Add(new("KIL’JAEDEN", 10));
        enemyList.Add(new("DEATHWING", 10));

        return enemyList;
    }

    public static Enemy GenerateEnemy(int size)
    {
        Random rnd = new Random();
        int r = rnd.Next(size);

        return GenerateEnemies()[r];
    }


}