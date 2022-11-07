namespace GameLogic;
class Enemy : Entity
{
    public string UglyOrc { get; set; }
    public string Boss { get; set; }

    public Enemy(string name, int id, int health, int level) : base(name, id, health, level)
    {
        
    }

    
}