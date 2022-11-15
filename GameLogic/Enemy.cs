namespace GameLogic;
public class Enemy : Entity
{
    private List<Enemy> enemies = new();
   
    public Enemy(string name) : base(name)
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
        Enemy myEnemies = new("Kel’Thuzad");
        Enemy myEnemies2 = new("Lich King");
        Enemy myEnemies3 = new("ARCHIMONDE");
        Enemy myEnemies4 = new("KIL’JAEDEN");
        Enemy myEnemies5 = new("DEATHWING");

        List<Enemy> enemyList = new();

        enemyList.Add(myEnemies);
        enemyList.Add(myEnemies2);
        enemyList.Add(myEnemies3);
        enemyList.Add(myEnemies4);
        enemyList.Add(myEnemies5);

        return enemyList;
    }

    public List<Enemy> GetRandomEnemy()
    {
        List<Enemy> randomEnemy = new();

        return randomEnemy;
    }



}