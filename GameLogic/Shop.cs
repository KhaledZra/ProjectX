using System.Net.Mail;

namespace GameLogic;

public class Shop
{
    public List<Item> _stockInShop { get; set; } = new();
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
    
    
}