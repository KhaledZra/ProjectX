using GameLogic;
namespace UserInterface;

public class output
{

    public static void MainMenu()
    {
        Console.WriteLine("Welcome to Heretics!");
        Console.WriteLine("Press [P] to play...");
        Console.WriteLine("[Q]uit");
    }

    public static void CharacterHandlerOutPut()
    {
        Console.WriteLine("[C]reate character");
        Console.WriteLine("[L]oad character"); // not possible yet without db
        Console.WriteLine("[R]eturn to MainMenu");
    }

    public static void ChooseCharacterVocation()
    {
        Console.WriteLine("Choose a Vocation");
        Console.WriteLine("[A]rcher");
        Console.WriteLine("[N]ecromancer");
        // Console.WriteLine("[W]arrior");
        Console.WriteLine("[W]izard");

    }
    public static void CharacterName()
    {
        Console.Write("Set name: ");
    }

    public static void ShopMenu()
    {
        Console.WriteLine("Welcome to Heretics shop");
        Console.WriteLine("[B]uy\n[S]ell\n[L]eave");
    }

    public static void BuyFromShopMenu()
    {
        Console.WriteLine("--------BUYING---------");
        Console.WriteLine("Example: The sword is yours now!");
        Console.WriteLine("[R]eturn");
    }

    public static void SellInShop()
    {
        Console.WriteLine("--------SELLING---------");
        Console.WriteLine("Example: The sword was sold!");
        Console.WriteLine("[R]eturn");
    }

    public static void TutorialMenu(Character player)
    {
        Console.WriteLine($"Hi! {player.Name}, Press [D]");
        Console.WriteLine("You are done with your practice! GOOD JOB!!");
    }
    
    public static void FightStartMenu(Character player)
    {
        Console.WriteLine($"{player.Name} your are fighting our enemies, SEND THEM TO HELL");
        Console.WriteLine("[F]ight!");
        Console.WriteLine("[R]un and live to see another day!");
    }

    public static void FightingMenu(Game game)
    {
        Console.WriteLine(game.HandleFighting(Enemy.TestEnemy())); // ska ändras sen
        Console.WriteLine("------------");
    }

    public static void WonMenu()
    {
        Console.WriteLine("You won the battle good job Soldier!!");
    }

    public static void LooseMenu()
    {
        Console.WriteLine("REST IN PEACE WE GONNA ALWYS HAVE YOU IN OUR MINDS HERO");
    }

    public static void Quit()
    {
        Console.WriteLine("Bye Solider, See you soon!");
    }

    public static void TestRoamingMenu()
    {
        Console.WriteLine("----walking around----");
        Console.WriteLine("1. Fight Club");
        Console.WriteLine("2. Shop");
        Console.WriteLine("3. tutorial");
        Console.WriteLine("4. Leave");
    }

}