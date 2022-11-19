using System.Linq.Expressions;

namespace GameLogic;

public class Item : Entity
{
    public Item(string name, int health, int level, int currency, Vocation vocation = new()) : base(name, vocation,
        currency)
    {
        Health = health;
        LevelStats.Level = level;
        Currency = currency;
    }
}