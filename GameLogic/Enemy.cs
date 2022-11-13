namespace GameLogic;
public class Enemy : Entity
{
    public Enemy(string name) : base(name)
    {
        
    }

    public static Enemy TestEnemy()
    {
        return new Enemy("Goblin_Test") 
            { Health = 100 , LevelStats = new LevelHandler()
                {Experience = 100} };
    }
}