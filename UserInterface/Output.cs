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
        Console.WriteLine("\n[C]reate character");
        Console.WriteLine("[L]oad character");
        Console.WriteLine("[R]eturn to MainMenu");
    }

    public static void ChooseCharacterClass()
    {
        Console.WriteLine("\nChoose a character");
        Console.WriteLine("[A]rcher");
        Console.WriteLine("[M]agician");
        Console.WriteLine("[W]arrior");
    }
    public static void CharacterName()

    {
        Console.WriteLine("\n[E]nter your nickname");
    }

    public static void ShopMenu()
    {
        Console.WriteLine("\nWelcome to Heretics shop");
        Console.WriteLine("[B]uy\n[S]ell\n[L]eave");
        Console.Write("Choice: ");
        Console.WriteLine("--------BUYING---------");
        Console.WriteLine("The sword is yours now!");
            
    }

    public static void TutorialMenu()
    {
        Console.WriteLine("\nHi! {NickName}, Press [D]");
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

    public static void Quit()
    {
        Console.WriteLine("Bye Solider, See you soon!");
    }

}