using DataManager;

namespace GameLogic;

public class Character : Entity
{
    public int CoordX { get; set; }
    public int CoordY { get; set; }
    public List<Item> InventoryItems { get; set; }
    public int FightEncounters { get; set; }
    public int MaxHp { get; set; } // used to keep track of when player is healing

    public Character(string name, int id, int currency = 5, Vocation vocation = Vocation.Unassigned) : base(name, vocation,
        currency)
    {
        Id = id;
        CoordX = 45; // hardkodat spawn, change later
        CoordY = 15;  // hardkodat spawn, change later
        InventoryItems = new List<Item>();
        LevelStats = new LevelHandler();
    }

    // Load Constructor, used for dapper to load from table
    public Character(int id, string name, int experience, int health, int gold, int vocation, int positionX, int positionY)
    {
        Id = id;
        Name = name;
        LevelStats = new LevelHandler();
        LevelStats.GainExperience(experience);
        MaxHp = health;
        Health = MaxHp;
        Currency = gold;
        Vocation = (Vocation)vocation;
        CoordX = positionX;
        CoordY = positionY;
        InventoryItems = Load.LoadCharacterItemsFromDb<Item>(Id);
    }

    private int TotalDamageFromItems()
    {
        int totalDamage = 0;

        foreach (var item in InventoryItems)
        {
            totalDamage += item.LevelStats.Level;
        }

        return totalDamage;
    }

    public override int DealDamage(int addOnDamage = 0)
    {
        return base.DealDamage(TotalDamageFromItems());
    }

    // Handles Characters health
    public void HealCharacter() => Health = MaxHp;
    public void IncreaseMaxHpOnLevelUp() => MaxHp += 10;
    
    // Movement methods
    public void MoveUp() => CoordY--;
    public void MoveDown() => CoordY++;
    public void MoveLeft() => CoordX--;
    public void MoveRight() => CoordX++;

    // Handles Character and sets stats accordingly
    public static void SetCharacterVocationStats(Character activePlayer)
    {
        if (activePlayer.Vocation == Vocation.Archer)
        {
            Stats.SetArcher(activePlayer);
        }
        else if (activePlayer.Vocation == Vocation.Mage)
        {
            Stats.SetMage(activePlayer);
        }
        else if (activePlayer.Vocation == Vocation.Warrior)
        {
            Stats.SetWarrior(activePlayer);
        }
    }
}