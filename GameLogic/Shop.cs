namespace GameLogic;

public class Shop
{
    public List<Item> StockInShop { get; set; }

    public Shop()
    {
        StockInShop = DefaultStock(); // Borde skickas från DB
    }

    private List<Item> DefaultStock() //not supposed to be here, list should be in DB
    {
        List<Item> tempList = new List<Item>();
        //distance weapons
        tempList.Add(new Item("Shuriken", 5, 1, 1));
        tempList.Add(new Item("Short Bow", 10, 1, 10));
        tempList.Add(new Item("Batarang", 50, 5, 25));
        tempList.Add(new Item("Long Bow", 20, 5, 30));
        tempList.Add(new Item("Crossbow", 30, 10, 100));
        tempList.Add(new Item("Fūma Shuriken, major throwing star", 25, 30, 150)); //large shurikens
        tempList.Add(new Item("Widow's Wail", 100, 49, 1500));

        //end game ranged weapons
        tempList.Add(new Item("The Spirit Spear Chastiefol", 10000, 50, 9999999)); //mythical
        tempList.Add(new Item("Death Note", 10000, 50, 9999999)); //mythical

        //Handwielded weapons
        tempList.Add(new Item("Rusty Sword", 10, 1, 1));
        tempList.Add(new Item("Butcher's Axe", 20, 5, 10));
        tempList.Add(new Item("Jagged Scimitar", 20, 5, 25));
        tempList.Add(new Item("Longsword", 30, 10, 30));
        tempList.Add(new Item("Skullcracker's Mace", 35, 10, 50));
        tempList.Add(new Item("Needle", 50, 30, 15000));
        tempList.Add(new Item("Kusanagi", 100, 49, 30000));
        tempList.Add(new Item("Stonecutter Axe", 100, 49, 90000));

        //end game handheld weapons    <
        tempList.Add(new Item("Newgate's Murakumogiri", 100, 49, 9999999)); //legendary
        tempList.Add(new Item("The Vorpal Blade", 100, 50, 9999999)); //legendary
        tempList.Add(new Item("Mihawk's Yoru", 1000, 50, 9999999)); //legendary
        tempList.Add(new Item("Orcus, Scythe of the Reaper", 1000, 50, 9999999)); //mythical
        tempList.Add(new Item("The Sword of Rupture, Ea", 10000, 50, 9999999)); //mythical

        return tempList;
    }
}