using System.Linq.Expressions;

namespace GameLogic;

public class Item : Entity
{
    public Item(string name, int health, int level, int currency, Vocation vocation = new()) : base(name, vocation,
        currency)
    {

        Name = name;
        Health = health;
        LevelStats.Level = level;
        Currency = currency;
        Vocation = vocation;
    }

    // Load Constructor, used for dapper to load from table
    public Item(int id, string name, int currency, int health, int level, int vocation)
    {
        Id = id;
        LevelStats = new LevelHandler();
        LevelStats.Level = level;
        Name = name;
        Currency = currency;
        Health = health;
        Vocation = (Vocation)vocation;
    }
}