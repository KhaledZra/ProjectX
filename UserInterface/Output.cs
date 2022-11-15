using GameLogic;

namespace UserInterface;

public class Output
{
    public static void MainMenu()
    {
        Console.WriteLine("Welcome to World of Heretics!");
        Console.WriteLine("Press [P] to play..\n..or press [Q] to quit game!");
    }

    public static void CharacterHandlerOutPut()
    {
        Console.WriteLine("Character menu:");
        Console.WriteLine("[C]reate character");
        Console.WriteLine("[L]oad character"); // not possible yet without db
        Console.WriteLine("[R]eturn to main menu");
    }

    public static void ChooseCharacterVocation()
    {
        Console.WriteLine("Choose a class by pressing the corresponding alphabetical character:");
        Console.WriteLine("[A]rcher - An expert in distance fighting.");
        Console.WriteLine("[M]age - Wielder of magic and spells.");
        Console.WriteLine("[W]arrior - User of handheld weaponry.");
    }

    public static void CharacterName()
    {
        Console.Write("Pick a name for your character: ");
    }

    public static void ShopMenu()
    {
        Console.WriteLine("Welcome to the WoH shop!");
        Console.WriteLine("[B]uy\n[S]ell\n[L]eave");
    }

    public static void BuyFromShop(List<Item> shopItems)
    {
        Console.WriteLine("--------BUYING---------");
        foreach (var item in shopItems)
        {
            Console.WriteLine($"{item.Name} - {item.Currency} ");
        }
        Console.WriteLine($"Example: You've bought \"item.Name\" from Shop");
        Console.WriteLine("[R]eturn");
    }

    public static void SellToShop(Character activePlayer)
    {
        foreach (var item in activePlayer.InventoryItems)
        {
            //bör listas med siffra för att avgöra vilket item som ska säljas i genom output/input
            Console.WriteLine($"{item.Name} - Sell for: {item.Currency} ");
        }

        Console.WriteLine("---------SELLING---------");
        Console.WriteLine($"Example: Your item {activePlayer.InventoryItems[1]}");
        Console.WriteLine("[R]eturn");
    }

    public static void TutorialMenu(Character player)
    {
        Console.WriteLine($"Hi! {player.Name}, press [D] to start your personalized tutorial.");
        Console.WriteLine("You are done with your practice young padawan! GOOD JOB!!");
    }

    public static void FightStartMenu(Character player)
    {
        Console.WriteLine($"{player.Name}, you´re fighting our enemies, SEND THEM TO HELL!");
        Console.WriteLine("[F]ight!");
        Console.WriteLine("[R]un away and live to fight another day!");
    }

    public static void FightingMenu(Game game)
    {
        //Console.WriteLine(game.HandleFighting(Enemy.TestEnemy())); // ska ändras sen
        Console.WriteLine("------------");
    }

    public static void WonMenu()
    {
        Console.WriteLine("You´ve defeated your enemy and won the battle!");
    }

    public static void LoseMenu(Character player)
    {
        Console.WriteLine($"RIP {player.Name}, you´ve died and will have to restart your journey!");
    }

    public static void Quit()
    {
        Console.WriteLine("Farewell young adventurer, your game is saved and we hope to see you soon!");
    }

    public static void TestRoamingMenu() //temporary fix for roaming map interactions
    {
        Console.WriteLine("---------ROAMING---------");
        Console.WriteLine("[1.] Fight Club");
        Console.WriteLine("[2.] Shop");
        Console.WriteLine("[3.] tutorial");
        Console.WriteLine("[4.] Leave");
    }
}