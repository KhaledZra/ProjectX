using DataManager;
using Dapper;

namespace GameLogic;

public class Shop
{
    public List<Item> StockInShop { get; set; }

    public Shop(Vocation playerVocation)
    {
        StockInShop = LoadFromDbDefaultStock(playerVocation); // Borde skickas från DB
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


    /*public List<Item> DefaultStock(Vocation playerVocation) //not supposed to be here, list should be in DB
    {
        List<Item> tempList = new List<Item>();

        if (playerVocation == Vocation.Archer)
        {
            //archer weapons
            tempList.Add(new Item("Shuriken", 5, 1, 1, Vocation.Archer));
            tempList.Add(new Item("Short Bow", 10, 1, 10, Vocation.Archer));
            tempList.Add(new Item("Batarang", 50, 5, 25, Vocation.Archer));
            tempList.Add(new Item("Long Bow", 20, 10, 30, Vocation.Archer));
            tempList.Add(new Item("Crossbow", 30, 25, 100, Vocation.Archer));
            tempList.Add(new Item("Fūma Shuriken, major throwing star", 25, 30, 150, Vocation.Archer)); //large shurikens
            tempList.Add(new Item("Widow's Wail", 1500, 49, 1500, Vocation.Archer));
            //end game archer weapons
            tempList.Add(new Item("The Spirit Spear Chastiefol", 15000, 95, 9999999, Vocation.Archer)); //mythical
        }
        else if (playerVocation == Vocation.Warrior)
        {
            //warrior weapons
            tempList.Add(new Item("Rusty Sword", 10, 1, 5, Vocation.Warrior));
            tempList.Add(new Item("Butcher's Axe", 15, 5, 10, Vocation.Warrior));
            tempList.Add(new Item("Jagged Scimitar", 20, 10, 25, Vocation.Warrior));
            tempList.Add(new Item("Longsword", 30, 15, 30, Vocation.Warrior));
            tempList.Add(new Item("Skullcracker's Mace", 30, 25, 50, Vocation.Warrior));
            tempList.Add(new Item("Needle", 50, 40, 15000, Vocation.Warrior));
            tempList.Add(new Item("Kusanagi", 125, 45, 30000, Vocation.Warrior));
            tempList.Add(new Item("Stonecutter Axe", 150, 50, 90000, Vocation.Warrior));
            //end game warrior weapons
            tempList.Add(new Item("Newgate's Murakumogiri", 1500, 65, 9999999, Vocation.Warrior)); //legendary
            tempList.Add(new Item("Mihawk's Yoru", 2000, 70, 9999999, Vocation.Warrior)); //legendary
            tempList.Add(new Item("The Vorpal Blade", 5000, 75, 9999999, Vocation.Warrior)); //legendary
            tempList.Add(new Item("The Sword of Rupture, Ea", 10000, 95, 9999999, Vocation.Warrior)); //mythical
        }
        else if (playerVocation == Vocation.Mage)
        {
            //mage weapons
            tempList.Add(new Item("Wooden Stick", 10, 1, 5, Vocation.Mage));
            tempList.Add(new Item("Wooden Wand", 15, 5, 10, Vocation.Mage));
            tempList.Add(new Item("Orb of inferno", 50, 15, 50, Vocation.Mage));
            tempList.Add(new Item("Book of neverending screams", 75, 25, 95, Vocation.Mage));
            tempList.Add(new Item("Eon Sceptre", 75, 35, 200, Vocation.Mage));
            tempList.Add(new Item("Long staff of Heretic", 100, 45, 1000, Vocation.Mage));
            tempList.Add(new Item("Wooden Wand", 200, 50, 2000, Vocation.Mage));
            //end game mage weapons
            tempList.Add(new Item("Death Note", 10000, 50, 9999999, Vocation.Mage)); //mythical
            tempList.Add(new Item("Orcus, Scythe of the Reaper", 1000, 50, 9999999, Vocation.Mage)); //mythical
        }

        return tempList;
    }*/
}