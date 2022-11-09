namespace UserInterface;

public class MenuOutput
{

    public static void MainMenu()
    {
        Console.WriteLine("Welcome to Heretics!");
        Console.WriteLine("Press [P] to play...");
        Console.WriteLine("[Q]uit");
    }

    public static void CharacterMenu()
    {
        Console.WriteLine("\n[C]reate character");
        Console.WriteLine("[L]oad character");
    }

    public static void CharacterName()
    {
        Console.WriteLine("\n[E]nter your nickname");
    }

    public static void ChooseCharacterClass()
    {
        Console.WriteLine("\nChoose a character");
        Console.WriteLine("[A]rcher");
        Console.WriteLine("[M]agician");
        Console.WriteLine("[W]arrior");
    }

    public static void ShopMenu()
    {
        Console.WriteLine("\nWelcome to Heretics shop");
        Console.WriteLine("[B]uy \n[Sell]");
    }

    public static void TutorialMenu()
    {
        Console.WriteLine("\nHi! {NickName}");
        Console.WriteLine("You are done with your practi! GOOD JOB!!");
    }

    public static void FightingMenu()
    {
        Console.WriteLine("\n{NickName} your are fighting our enemies, SEND THEM TO HELL");
    }

    public static void WonMenu()
    {
        Console.WriteLine("\nYou won the battle good job Soldier!!");
    }

    public static void LooseMenu()
    {
        Console.WriteLine("\nREST IN PEACE WE GONNA ALWYS HAVE YOU IN OUR MINDS HERO");
    }

}

