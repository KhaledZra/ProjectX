namespace GameLogic;

public abstract class Entity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public LevelHandler LevelStats { get; set; }

    public int Currency { get; set; } //eventually decimalF

    public Entity(string name)
    {
        Name = name;
        Health = 0;
        LevelStats = new LevelHandler();
    }

    public override string ToString()
    {
        return $"{Id}, {Name}, {Health}, {LevelStats.ToString()}";
    }

    public int DealDamage()
    {
        int baseDamage = 1;

        return baseDamage + LevelStats.Level;
    }
}