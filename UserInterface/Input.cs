namespace UserInterface;

public abstract class Input
{
    public static GameState MainMenuInput()
    {
        ConsoleKey input = Console.ReadKey().Key;

        if (input == ConsoleKey.P)
        {
            return GameState.CharacterHandler;
        }

        else if (input == ConsoleKey.Q)
        {
            return GameState.QuitGame;
        }

        return GameState.RoamingMap;

    }

    public static GameState CharacterMenuInput()
    {
        ConsoleKey input = Console.ReadKey().Key;

        if (input == ConsoleKey.C)
        {
            return GameState.SetCharacterClass;
        }

        else if (input == ConsoleKey.L)
        {
            return GameState.LoadCharacter;
        }

        else if (input == ConsoleKey.R)
        {
            return GameState.MainMenu;
        }

        return GameState.CharacterHandler;

    }

    public static GameState CharacterNameInput()
    {
        ConsoleKey input = Console.ReadKey().Key;

        if (input == ConsoleKey.E)
        {
            return GameState.SetCharacterName;
        }

        else if (input == ConsoleKey.L)
        {
            return GameState.MainMenu;
        }
        return GameState.SetCharacterName;
    }

    public static GameState ShopMenuInput()
    {
        ConsoleKey input = Console.ReadKey().Key;
        Console.Clear();

        if (input == ConsoleKey.L)
        {
            return GameState.RoamingMap;
        }

        if (input == ConsoleKey.B)
        {
            return GameState.BuyFromShop;
        }

        else if (input == ConsoleKey.S)
        {
            return GameState.SellInShop;
        }

        return GameState.ShopMenu;
    }

    public static GameState TutorialMenuInput()
    {
        ConsoleKey input = Console.ReadKey().Key;

        if (input == ConsoleKey.D)
        {
            return GameState.RoamingMap;
        }
        
        return GameState.TutorialMenu;
    }

    public static GameState FightingMenuInput()
    {
        ConsoleKey input = Console.ReadKey().Key;

        if (input == ConsoleKey.F)
        {
            return GameState.WonMenu;
        }

        return GameState.RoamingMap;
    }

}