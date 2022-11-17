namespace GameLogic;
public class Enemy : Entity
{ 
    public Enemy(string name, int currency = 10, int health = 50, Vocation vocation = Vocation.Unassigned) : base(name, vocation, currency)
    {
        Health = health;
    }
}