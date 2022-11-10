namespace UserInterface;

public abstract class Input
{
    public static void MainMenuInput(ConsoleKey input)
    {
        
    }
    
    public static string CharacterMenuInput(ConsoleKey input) // Inte klar
    {
        string characterClass = Console.ReadLine();
        // behövs o felhantera här
        return characterClass;
    }
    
    public static string CharacterNameInput(ConsoleKey input) // Inte klar
    {
        string characterName = Console.ReadLine();
        // behövs o felhantera här
        return characterName;
    }
    
    public static GameState ShopMenuInput() // Inte klar
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();
        
        if (input == ConsoleKey.L)
        {
            return GameState.RoamingMap;
        }
        
        if (input == ConsoleKey.B)
        {
            Console.WriteLine("--------BUYING---------");
            // Console.WriteLine("[S]word");
            Console.ReadKey(true);
        }
        else if (input == ConsoleKey.S)
        {
            Console.WriteLine("--------SELLING---------");
            Console.ReadKey(true);
            // input = Console.ReadKey(true).Key;
        }

        return GameState.ShopMenu;
    }
}