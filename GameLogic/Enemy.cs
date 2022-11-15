namespace GameLogic;
public class Enemy : Entity
{
    private List<Enemy> enemies = new();
   
    public Enemy(string name, int curruncy) : base(name, curruncy)
    {
        
    }

    public static Enemy TestEnemy()
    {
        return new Enemy("Goblin_Test") 
            { Health = 100 , LevelStats = new LevelHandler()
                {Experience = 100} };
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

    public List<Enemy> GetRandomEnemy()
    {
        List<Enemy> randomEnemy = new();

        return randomEnemy;
    }



}