namespace UserInterface;

public class DrawMenu
{

    public static void MainMenu()
    {
        Console.WriteLine("Welcome to Heretics!");
        Console.WriteLine("Press [P] to play...");
        Console.WriteLine("[Q]uit");
    }

    public static void CharacterMenu()
    {
        Console.WriteLine("[C]reate character");
        Console.WriteLine("[L]oad character");
    }

    public static void CharacterName()
    {
        Console.WriteLine("[E]nter your nickname");
    }

    public static void ChooseCharacterClass()
    {
        Console.WriteLine("Choose a character");
        Console.WriteLine("[A]rcher");
        Console.WriteLine("[M]agician");
        Console.WriteLine("[W]arrior");
    }

    public static void ShopMenu()
    {
        Console.WriteLine("Welcome to Heretics shop");
        Console.WriteLine("[B]uy \n[Sell]");
    }

    public static void TutorialMenu()
    {
        Console.WriteLine("Hi! {NickName} are you ready to practis");
        Console.WriteLine("You are done with your practis! GOOD JOB!!");
    }

    public static void FightingMenu()
    {
        Console.WriteLine("{NickName} your are fighting our enemies, SEND THEM TO HELL");
    }

    public static void WonMenu()
    {
        Console.WriteLine("You the battle good job Soldier!!");
    }

    public static void LooseMenu()
    {
        Console.WriteLine("REST IN PEACE WE GONNA ALWYS HAVE YOU IN OUR MINDS HERO");
    }

}

