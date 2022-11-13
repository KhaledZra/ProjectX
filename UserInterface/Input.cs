using GameLogic;

namespace UserInterface;

public abstract class Input
{
    public static GameState MainMenuInput()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.P)
        {
            return GameState.CharacterHandler;
        }

        if (input == ConsoleKey.Q)
        {
            return GameState.QuitGame;
        }

        return GameState.MainMenu;
    }

    public static GameState CharacterMenuInput()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.C)
        {
            return GameState.SetCharacterVocation;
        }

        if (input == ConsoleKey.L)
        {
            return GameState.LoadCharacter;
        }

        if (input == ConsoleKey.R)
        {
            return GameState.MainMenu;
        }

        return GameState.CharacterHandler;
    }
    
    public static GameState CharacterVocationInput()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.A)
        {
            return GameState.SetCharacterName;
        }
        
        if (input == ConsoleKey.N)
        {
            return GameState.SetCharacterName;
        }
        
        if (input == ConsoleKey.W)
        {
            return GameState.SetCharacterName;
        }

        // set Vocation in game object
        return GameState.SetCharacterVocation;
    }

    public static GameState CharacterNameInput(Character player)
    {
        player.Name = Console.ReadLine();
        Console.Clear();

        if (!string.IsNullOrWhiteSpace(player.Name))
        {
            return GameState.RoamingMap;
        }

        // set name in game object
        return GameState.SetCharacterName;
    }

    public static GameState ShopMenuInput()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.L)
        {
            return GameState.RoamingMap;
        }

        if (input == ConsoleKey.B)
        {
            return GameState.BuyFromShop;
        }

        if (input == ConsoleKey.S)
        {
            return GameState.SellInShop;
        }

        return GameState.ShopMenu;
    }
    
    public static GameState ShopBuyMenuInput()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.R)
        {
            return GameState.ShopMenu;
        }

        return GameState.BuyFromShop;
    }
    
    public static GameState ShopSellMenuInput()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.R)
        {
            return GameState.ShopMenu;
        }

        return GameState.SellInShop;
    }

    public static GameState TutorialMenuInput()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.D)
        {
            return GameState.RoamingMap;
        }
        
        return GameState.TutorialMenu;
    }

    public static GameState FightingMenuInput()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.F)
        {
            return GameState.Fighting;
        }
        if (input == ConsoleKey.R)
        {
            return GameState.RoamingMap;
        }

        return GameState.FightMenu;
    }
    
    // public static void FightingInput() // kanske om man behöver göra något mid fight?
    // {
    //     // // Fight to death or leave
    //     // while (Console.ReadKey(true).Key != ConsoleKey.R)
    //     // {
    //     //     Console.Clear();
    //     // }
    // }
    
    public static GameState TestRoamingMenuInput()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.D1)
        {
            return GameState.FightMenu;
        }
        
        if (input == ConsoleKey.D2)
        {
            return GameState.ShopMenu;
        }
        
        if (input == ConsoleKey.D3)
        {
            return GameState.TutorialMenu;
        }
        
        if (input == ConsoleKey.D4)
        {
            return GameState.QuitGame;
        }

        return GameState.RoamingMap;
    }
}