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
            return GameState.CreateCharacter;
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
            return GameState.VocSetPickName;
        }

        if (input == ConsoleKey.M)
        {
            player.Vocation = Vocation.Mage;
            return GameState.VocSetPickName;
        }

        if (input == ConsoleKey.W)
        {
            player.Vocation = Vocation.Warrior;
            return GameState.VocSetPickName;
        }
        
        return GameState.CreateCharacter;
    }

    public static GameState SetCharacterName(Game game)
    {
        game.Player.Name = Console.ReadLine();
        Console.Clear();

        if (!string.IsNullOrWhiteSpace(game.Player.Name))
        {
            game.SaveNewCharacter(); // saves to DB
            return GameState.RoamingMap;
        }

        // set name in game object
        return GameState.VocSetPickName;
    }

    public static GameState GetFromShopMenu()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.B) // Browse stock
        {
            return GameState.Browsing;
        }

        if (input == ConsoleKey.S) // Sell to shop
        {
            return GameState.Selling;
        }

        if (input == ConsoleKey.R) // Return to map
        {
            return GameState.RoamingMap;
        }

        return GameState.Shop;
    }

    // public static GameState ItemInStock()
    // {
    //     ConsoleKey input = Console.ReadKey(true).Key;
    //     Console.Clear();
    //
    //     if (input == ConsoleKey.R)
    //     {
    //         return GameState.Shop;
    //     }
    //
    //     return GameState.Browsing;
    // }

    public static GameState BrowseAndPickItem(Shop shop, Character activePlayer) //browsing shouldnt be in the shop start menu?
    {
        string input = Console.ReadLine();
        Console.Clear();
        
        if (input.ToLower() == "r")
        {
            return GameState.Shop;
        }

        if (input.ToLower() == "h")
        {
            if (activePlayer.Currency >= 10)
            {
                if (activePlayer.Health == activePlayer.MaxHp)
                {
                    Console.WriteLine("You already are max health!");
                    return GameState.Browsing;
                }
                else
                {
                    activePlayer.Currency -= 10;
                    activePlayer.HealCharacter();
                    Console.WriteLine("Purchased full heal, for 10c");
                }
            }
            else
            {
                Output.WriteLineMultiColored((ConsoleColor.Red, "Insufficient funds, "), (ConsoleColor.White, "please check back when you got more "),
                    (ConsoleColor.Green, "gold"));
            }
            return GameState.Browsing;
        }

        if (int.TryParse(input, out int result))
        {
            if (result > -1)
            {
                if (result < shop.StockInShop.Count)
                {
                    if (activePlayer.Currency >= shop.StockInShop[result].Currency)
                    {
                        foreach (var item in activePlayer.InventoryItems)
                        {
                            if (item.Id == shop.StockInShop[result].Id)
                            {
                                Console.WriteLine("You already own this item!");
                                return GameState.Browsing;
                            }
                        }
                        activePlayer.Currency -= shop.StockInShop[result].Currency;
                        activePlayer.InventoryItems.Add(shop.StockInShop[result]);
                        Game.SaveCharacterInventory(activePlayer, shop.StockInShop[result]);
                        Console.WriteLine($"Purchased 1 {shop.StockInShop[result].Name}, for {shop.StockInShop[result].Currency}c");
                    }
                    else
                        Output.WriteLineMultiColored((ConsoleColor.Red, "Insufficient funds, "), (ConsoleColor.White, "please check back when you got more "),
                            (ConsoleColor.Green, "gold"));
                }
            }
            else
            {
                Console.WriteLine("Negative number!");
            }
        }
        else
        {
            Console.WriteLine("Not a number");
        }
        return GameState.Browsing;
    }
    
    
    public static GameState SellInventory(Character player)
    {
        string input = Console.ReadLine();
        Console.Clear();

        if (input.ToLower() == "r")
        {
            return GameState.Shop;
        }

        if (int.TryParse(input, out int result))
        {
            if (result > -1)
            {
                if (result < player.InventoryItems.Count)
                {
                    player.Currency += player.InventoryItems[result].Currency;
                    Console.WriteLine($"Sold 1 {player.InventoryItems[result].Name}, for {player.InventoryItems[result].Currency}c");
                    Game.RemoveSoldItem(player.Id, player.InventoryItems[result].Id);
                    player.InventoryItems.RemoveAt(result);
                }
            }
            else
            {
                Console.WriteLine("Negative number!");
            }
        }
        else
        {
            Console.WriteLine("Not a number");
        }
        return GameState.Selling;
    }

    public static GameState TutorialMenu()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.R)
        {
            return GameState.RoamingMap;
        }

        return GameState.Tutorial;
    }
    
    public static GameState MountainMenu()
    {
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.R)
        {
            return GameState.RoamingMap;
        }

        return GameState.Mountain;
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

        return GameState.Arena;
    }

    public static GameState MovePlayerInput(Character player, Map map)
    {
        ConsoleKey input = Console.ReadKey(true).Key;

        if (input == ConsoleKey.UpArrow || input == ConsoleKey.W)
        {
            player.MoveUp();
            if (map.TwoDMap[player.CoordX, player.CoordY] != 1)
            {
                if (map.TwoDMap[player.CoordX, player.CoordY] > 5)
                {
                    GameState gameState = (GameState)map.TwoDMap[player.CoordX, player.CoordY];
                    player.MoveDown();
                    return gameState;
                }

                player.MoveDown();
            }
        }
        else if (input == ConsoleKey.DownArrow || input == ConsoleKey.S)
        {
            player.MoveDown();
            if (map.TwoDMap[player.CoordX, player.CoordY] != 1 && map.TwoDMap[player.CoordX, player.CoordY] != 4)
            {
                if (map.TwoDMap[player.CoordX, player.CoordY] > 5)
                {
                    GameState gameState = (GameState)map.TwoDMap[player.CoordX, player.CoordY];
                    player.MoveUp();
                    return gameState;
                }

                player.MoveUp();
            }
        }
        else if (input == ConsoleKey.RightArrow || input == ConsoleKey.D)
        {
            player.MoveRight();
            if (map.TwoDMap[player.CoordX, player.CoordY] != 1 && map.TwoDMap[player.CoordX, player.CoordY] != 4)
            {
                if (map.TwoDMap[player.CoordX, player.CoordY] > 5)
                {
                    GameState gameState = (GameState)map.TwoDMap[player.CoordX, player.CoordY];
                    player.MoveLeft();
                    return gameState;
                }

                player.MoveLeft();
            }
        }
        else if (input == ConsoleKey.LeftArrow || input == ConsoleKey.A)
        {
            player.MoveLeft();
            if (map.TwoDMap[player.CoordX, player.CoordY] != 1 && map.TwoDMap[player.CoordX, player.CoordY] != 4)
            {
                if (map.TwoDMap[player.CoordX, player.CoordY] > 5)
                {
                    GameState gameState = (GameState)map.TwoDMap[player.CoordX, player.CoordY];
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
            return GameState.Arena;
        }

        if (input == ConsoleKey.D2)
        {
            return GameState.Shop;
        }

        if (input == ConsoleKey.D3)
        {
            return GameState.Tutorial;
        }

        if (input == ConsoleKey.D4)
        {
            return GameState.QuitGame;
        }

        return GameState.RoamingMap;
    }
}