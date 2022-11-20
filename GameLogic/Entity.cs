namespace GameLogic;

public abstract class Entity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public LevelHandler LevelStats { get; set; }
    public int Currency { get; set; } //eventually decimalF
    public Vocation Vocation { get; set; }

    public Entity(string name,Vocation vocation, int currencyValue)
    {
        Name = name;
        Health = 0;
        LevelStats = new LevelHandler();
        Currency = currencyValue;
        Vocation = vocation;
    }

    public Entity()
    {
        
    }

    public override string ToString()
    {
        return $"{Id}, {Name}, {Health}, {LevelStats.ToString()}";
    }

    public virtual int DealDamage(int addOnDamage = 0)
    {
        int baseDamage = 1;

        return baseDamage + addOnDamage;
    }
}