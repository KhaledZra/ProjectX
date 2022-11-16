using System.Linq.Expressions;

namespace GameLogic;

public class Item : Entity
{
    public List<Item> _usableItems = new List<Item>();
    private List<Item> _lootableItems = new List<Item>();

    public Item(string name, int health, int level, int currency, Vocation vocation = new()) : base(name, vocation,
        currency)
    {
        Health = health;
        LevelStats.Level = level;
        Currency = currency;
        SetItemList();
    }

    public static List<Item> GetItemList(List<Item> _usableItems)
    {
        List<Item> shopItems = new();
        shopItems.Add(_usableItems.Find(item => item._usableItems.Exists(item => item._usableItems.Contains(item))));
        return _usableItems;
    }

    private void SetItemList()
    {
        //distance weapons
        _usableItems.Add(new Item("Shuriken", 5, 1, 1));
        _usableItems.Add(new Item("Short Bow", 10, 1, 10));
        _usableItems.Add(new Item("Batarang", 50, 5, 25));
        _usableItems.Add(new Item("Long Bow", 20, 5, 30));
        _usableItems.Add(new Item("Crossbow", 30, 10, 100));
        _usableItems.Add(new Item("Fūma Shuriken, major throwing star", 25,
            30, 150)); //large shurikens to cut bodies in half
        _lootableItems.Add(new Item("Widow's Wail", 100, 49, 1500));

        //end game ranged weapons
        _lootableItems.Add(new Item("The Spirit Spear Chastiefol", 10000, 50, 9999999)); //mythical
        _lootableItems.Add(new Item("Death Note", 10000, 50, 9999999)); //mythical

        //Handwielded weapons
        _usableItems.Add(new Item("Rusty Sword", 10, 1, 1));
        _usableItems.Add(new Item("Butcher's Axe", 20, 5, 10));
        _usableItems.Add(new Item("Jagged Scimitar", 20, 5, 25));
        _usableItems.Add(new Item("Longsword", 30, 10, 30));
        _usableItems.Add(new Item("Skullcracker's Mace", 35, 10, 50));
        _lootableItems.Add(new Item("Needle", 50, 30, 15000));
        _lootableItems.Add(new Item("Kusanagi", 100, 49, 30000));
        _usableItems.Add(new Item("Stonecutter Axe", 100, 49, 90000));

        //end game handheld weapons    <
        _lootableItems.Add(new Item("Newgate's Murakumogiri", 100, 49, 9999999)); //legendary
        _lootableItems.Add(new Item("The Vorpal Blade", 100, 50, 9999999)); //legendary
        _lootableItems.Add(new Item("Mihawk's Yoru", 1000, 50, 9999999)); //legendary
        _lootableItems.Add(new Item("Orcus, Scythe of the Reaper", 1000, 50, 9999999)); //mythical
        _lootableItems.Add(new Item("The Sword of Rupture, Ea", 10000, 50, 9999999)); //mythical
    }
}