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
            return GameState.CharacterOptions;
        }

        if (input == ConsoleKey.Q)
        {
            return GameState.QuitGame;
        }

        return GameState.MainMenu;
    }

    public static GameState CreateNewCharacter()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.C)
        {
            return GameState.PickVocation;
        }

        if (input == ConsoleKey.L)
        {
            return GameState.LoadCharacter;
        }

        if (input == ConsoleKey.R)
        {
            return GameState.MainMenu;
        }

        return GameState.CharacterOptions;
    }

    public static GameState SetCharacterVocation(Character player)
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.A)
        {
            player.Vocation = Vocation.Archer;
            return GameState.PickName;
        }

        if (input == ConsoleKey.M)
        {
            player.Vocation = Vocation.Mage;
            return GameState.PickName;
        }

        if (input == ConsoleKey.W)
        {
            player.Vocation = Vocation.Warrior;
            return GameState.PickName;
        }

        // set Vocation in game object
        return GameState.PickVocation;
    }

    public static GameState SetCharacterName(Character player)
    {
        player.Name = Console.ReadLine();
        Console.Clear();

        if (!string.IsNullOrWhiteSpace(player.Name))
        {
            return GameState.RoamingMap;
        }

        // set name in game object
        return GameState.PickName;
    }

    public static GameState GetFromShopMenu()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.B) // Browse stock
        {
            return GameState.BrowsingStock;
        }

        if (input == ConsoleKey.S) // Sell to shop
        {
            return GameState.SellingToShop;
        }

        if (input == ConsoleKey.R) // Return to map
        {
            return GameState.RoamingMap;
        }

        return GameState.InsideShop;
    }

    public static GameState ItemInStock()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.R)
        {
            return GameState.InsideShop;
        }

        return GameState.BrowsingStock;
    }

    public static GameState SellInventory()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.R)
        {
            return GameState.InsideShop;
        }

        return GameState.SellingToShop;
    }

    public static GameState TutorialMenu()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.T)
        {
            Output.TutorialOutput();
            Console.ReadKey();
            return GameState.InsideTutorial;
        }

        if (input == ConsoleKey.R)
        {
            return GameState.RoamingMap;
        }

        return GameState.InsideTutorial;
    }

    public static GameState FightingMenu()
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

    public static GameState MovePlayerInput(Character player, Map map)
    {
        ConsoleKey input = Console.ReadKey(true).Key;

        if (input == ConsoleKey.UpArrow)
        {
            player.MoveUp();
            if (map._twoDMap[player.CoordX, player.CoordY] != 1)
            {
                if (map._twoDMap[player.CoordX, player.CoordY] > 5)
                {
                    GameState gameState = (GameState)map._twoDMap[player.CoordX, player.CoordY];
                    player.MoveDown();
                    return gameState;
                }

                player.MoveDown();
            }
        }
        else if (input == ConsoleKey.DownArrow)
        {
            player.MoveDown();
            if (map._twoDMap[player.CoordX, player.CoordY] != 1 && map._twoDMap[player.CoordX, player.CoordY] != 4)
            {
                if (map._twoDMap[player.CoordX, player.CoordY] > 5)
                {
                    GameState gameState = (GameState)map._twoDMap[player.CoordX, player.CoordY];
                    player.MoveUp();
                    return gameState;
                }

                player.MoveUp();
            }
        }
        else if (input == ConsoleKey.RightArrow)
        {
            player.MoveRight();
            if (map._twoDMap[player.CoordX, player.CoordY] != 1 && map._twoDMap[player.CoordX, player.CoordY] != 4)
            {
                if (map._twoDMap[player.CoordX, player.CoordY] > 5)
                {
                    GameState gameState = (GameState)map._twoDMap[player.CoordX, player.CoordY];
                    player.MoveLeft();
                    return gameState;
                }

                player.MoveLeft();
            }
        }
        else if (input == ConsoleKey.LeftArrow)
        {
            player.MoveLeft();
            if (map._twoDMap[player.CoordX, player.CoordY] != 1 && map._twoDMap[player.CoordX, player.CoordY] != 4)
            {
                if (map._twoDMap[player.CoordX, player.CoordY] > 5)
                {
                    GameState gameState = (GameState)map._twoDMap[player.CoordX, player.CoordY];
                    player.MoveRight();
                    return gameState;
                }

                player.MoveRight();
            }
        }

        return GameState.RoamingMap;
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
            return GameState.InsideShop;
        }

        if (input == ConsoleKey.D3)
        {
            return GameState.InsideTutorial;
        }

        if (input == ConsoleKey.D4)
        {
            return GameState.QuitGame;
        }

        return GameState.RoamingMap;
    }
}