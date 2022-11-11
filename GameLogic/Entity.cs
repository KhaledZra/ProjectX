namespace GameLogic;
public abstract class Entity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public LevelHandler Level { get; set; }

    public Entity(string name)
    {
        Name = name;
        Health = 0;
        Level = new LevelHandler();
    }
    public override string ToString()
    {
        return $"{Id}, {Name}, {Health}, {Level.ToString()}";
    }

    public int DealDamage()
    {
        return 1 + Level.Level;
    }

}
