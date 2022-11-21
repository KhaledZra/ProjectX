using DataManager;

namespace GameLogic;

public class Shop
{
    public List<Item> StockInShop { get; set; }

    public Shop(Vocation playerVocation)
    {
        StockInShop = LoadFromDbDefaultStock(playerVocation);
    }

    private static List<Item> LoadFromDbDefaultStock(Vocation playerVocation)
    {
        if (playerVocation == Vocation.Archer)
        {
            return Load.LoadFromDbWhere<Item>("item", "vocation = 1");
            //sqlCode = $"SELECT (item.name, item.health, item.level, item.currency, item.vocation) FROM item WHERE item.vocation = 1;";
        }

        if (playerVocation == Vocation.Warrior)
        {
            return Load.LoadFromDbWhere<Item>("item", "vocation = 2");
            //sqlCode = $"SELECT (item.name, item.health, item.level, item.currency, item.vocation) FROM item WHERE item.vocation = 3;";
        }

        if (playerVocation == Vocation.Mage)
        {
            return Load.LoadFromDbWhere<Item>("item", "vocation = 3");
            //sqlCode = $"SELECT (item.name, item.health, item.level, item.currency, item.vocation) FROM item WHERE item.vocation = 2;";
        }

        return new List<Item>();
    }
}