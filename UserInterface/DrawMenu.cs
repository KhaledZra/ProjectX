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

}

