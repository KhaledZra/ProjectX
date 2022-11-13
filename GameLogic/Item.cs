namespace GameLogic;

class Item : Entity
{
    private List<Item> _usableItems = new List<Item>();

    public Item(string name, int health, int level) : base(name)
    {
        Health = health;
        Level.Level = level;
    }

    public void SetItemList()
    {
        //distance weapons
        _usableItems.Add(new Item("Shuriken", 5, 1));
        _usableItems.Add(new Item("Short Bow", 10, 1));
        _usableItems.Add(new Item("Batarang", 50, 5));
        _usableItems.Add(new Item("Long Bow", 20, 5));
        _usableItems.Add(new Item("Crossbow", 30, 10));
        _usableItems.Add(new Item("Fūma Shuriken, major throwing star", 25, 30)); //large shurikens to cut bodies in half
        _usableItems.Add(new Item("Widow's Wail", 100, 49));
        
        //end game ranged weapons
        _usableItems.Add(new Item("The Spirit Spear Chastiefol", 10000, 50)); //mythical
        _usableItems.Add(new Item("Death Note", 10000, 50)); //mythical

        //Handwielded weapons
        _usableItems.Add(new Item("Rusty Sword", 10, 1));
        _usableItems.Add(new Item("Butcher's Axe", 20, 5));
        _usableItems.Add(new Item("Jagged Scimitar", 20, 5));
        _usableItems.Add(new Item("Longsword", 30, 10));
        _usableItems.Add(new Item("Skullcracker's Mace", 35, 10));
        _usableItems.Add(new Item("Needle", 50, 30));
        _usableItems.Add(new Item("Kusanagi", 100, 49));
        _usableItems.Add(new Item("Stonecutter Axe", 100, 49));

        //end game handheld weapons    <
        _usableItems.Add(new Item("Newgate's Murakumogiri", 100, 49)); //legendary
        _usableItems.Add(new Item("The Vorpal Blade", 100, 50)); //legendary
        _usableItems.Add(new Item("Mihawk's Yoru", 1000, 50)); //legendary
        _usableItems.Add(new Item("Orcus, Scythe of the Reaper", 1000, 50)); //mythical
        _usableItems.Add(new Item("The Sword of Rupture, Ea", 10000, 50)); //mythical
        
        
    }
}