using System.Net.Mail;

namespace GameLogic;

public class Shop
{
    private List<Item> _stockInShop { get; set; } = new();
    public static int Currency { get; set; }

    public Shop()
    {
        //_stockInShop = new List<Item>();
        Currency = 100000000; // Shop starts with 100 gold
        //SetItemToShopList();
        GetStockOfShop(_stockInShop);
    }

    public override string ToString()
    {
        return $"{_stockInShop} - Prize: {Currency}";
    }

    public static List<Item> GetStockOfShop(List<Item> shopItems)
    {
        return shopItems.ToList();
    }

    private void DefaultStock() //not supposed to be here
    {
        //distance weapons
        _stockInShop.Add(new Item("Shuriken", 5, 1, 1));
        _stockInShop.Add(new Item("Short Bow", 10, 1, 10));
        _stockInShop.Add(new Item("Batarang", 50, 5, 25));
        _stockInShop.Add(new Item("Long Bow", 20, 5, 30));
        _stockInShop.Add(new Item("Crossbow", 30, 10, 100));
        _stockInShop.Add(new Item("Fūma Shuriken, major throwing star", 25, 30, 150)); //large shurikens
        _stockInShop.Add(new Item("Widow's Wail", 100, 49, 1500));

        //end game ranged weapons
        _stockInShop.Add(new Item("The Spirit Spear Chastiefol", 10000, 50, 9999999)); //mythical
        _stockInShop.Add(new Item("Death Note", 10000, 50, 9999999)); //mythical

        //Handwielded weapons
        _stockInShop.Add(new Item("Rusty Sword", 10, 1, 1));
        _stockInShop.Add(new Item("Butcher's Axe", 20, 5, 10));
        _stockInShop.Add(new Item("Jagged Scimitar", 20, 5, 25));
        _stockInShop.Add(new Item("Longsword", 30, 10, 30));
        _stockInShop.Add(new Item("Skullcracker's Mace", 35, 10, 50));
        _stockInShop.Add(new Item("Needle", 50, 30, 15000));
        _stockInShop.Add(new Item("Kusanagi", 100, 49, 30000));
        _stockInShop.Add(new Item("Stonecutter Axe", 100, 49, 90000));

        //end game handheld weapons    <
        _stockInShop.Add(new Item("Newgate's Murakumogiri", 100, 49, 9999999)); //legendary
        _stockInShop.Add(new Item("The Vorpal Blade", 100, 50, 9999999)); //legendary
        _stockInShop.Add(new Item("Mihawk's Yoru", 1000, 50, 9999999)); //legendary
        _stockInShop.Add(new Item("Orcus, Scythe of the Reaper", 1000, 50, 9999999)); //mythical
        _stockInShop.Add(new Item("The Sword of Rupture, Ea", 10000, 50, 9999999)); //mythical
    }
}