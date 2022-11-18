using GameLogic;

namespace UserInterface;

public class Output
{
    public static void MainMenu()
    {
        WriteLineMultiColored((ConsoleColor.Red, "- "), (ConsoleColor.White, "Welcome to the World of Heretics"),
            (ConsoleColor.Red, " -"));
        WriteLineMultiColored((ConsoleColor.White, "Press "), (ConsoleColor.Green, "[P]"),
            (ConsoleColor.White, " to play.."));
        WriteLineMultiColored((ConsoleColor.White, "..or "), (ConsoleColor.Red, "[Q]"),
            (ConsoleColor.White, " to quit game.."));
    }

    public static void CharacterHandlerOutPut()
    {
        WriteLineMultiColored((ConsoleColor.Red, "---------"), (ConsoleColor.White, "CHARACTER"),
            (ConsoleColor.Red, "---------"));
        WriteLineMultiColored((ConsoleColor.Red, "[C]"), (ConsoleColor.White, "reate character"),
            (ConsoleColor.White, "."));
        WriteLineMultiColored((ConsoleColor.Red, "[L]"), (ConsoleColor.White, "oad character"),
            (ConsoleColor.White, "."));
        WriteLineMultiColored((ConsoleColor.Red, "[R]"), (ConsoleColor.White, "eturn to main menu"),
            (ConsoleColor.White, "."));
    }

    public static void ChooseCharacterVocation()
    {
        Console.WriteLine("Choose a class by pressing the corresponding alphabetical character:");
        WriteLineMultiColored((ConsoleColor.Green, "[A]"),
            (ConsoleColor.White, "rcher - An expert in distance fighting"), (ConsoleColor.White, "."));
        WriteLineMultiColored((ConsoleColor.Cyan, "[M]"), (ConsoleColor.White, "age - Wielder of magic and spells"),
            (ConsoleColor.White, "."));
        WriteLineMultiColored((ConsoleColor.Red, "[W]"), (ConsoleColor.White, "arrior - User of handheld weaponry"),
            (ConsoleColor.White, "."));
    }

    public static void CharacterName(Vocation chosenVocation) //behöver kunna använda klassen till karaktären om så är möjligt
    {
        Console.Write($"Pick a suitable name for your {chosenVocation}: ");
    }

    public static void ShopMainMenu()
    {
        WriteLineMultiColored((ConsoleColor.Red, "---------"), (ConsoleColor.White, "SHOP"),
            (ConsoleColor.Red, "---------"));
        WriteLineMultiColored((ConsoleColor.Red, "[B] "), (ConsoleColor.White, " - Buy "),
            (ConsoleColor.White, "items."));
        WriteLineMultiColored((ConsoleColor.Green, "[S] "), (ConsoleColor.White, " - Sell "),
            (ConsoleColor.White, "items."));
        WriteLineMultiColored((ConsoleColor.Red, "[R] "), (ConsoleColor.White, " - Return "),
            (ConsoleColor.White, "to map."));
    }

    public static void StockInShop(List<Item> shopStock, Character activePlayer) //List<Item> stockList
    {
        WriteLineMultiColored((ConsoleColor.Red, "---------"), (ConsoleColor.White, "Items in stock"),
            (ConsoleColor.Red, "---------"));
        for (int itemIndex = 0; itemIndex < shopStock.Count; itemIndex++)
        {
            // Console.WriteLine($"[{itemIndex}]"); // {shopStock[itemIndex]}.Name}} - Buy for: {shopStock[itemIndex]}.Currency}}
            WriteLineMultiColored((ConsoleColor.Red, $"[{itemIndex}] "),
                (ConsoleColor.White, $"{shopStock[itemIndex].Name} - Cost: "),
                (ConsoleColor.Green, $"{shopStock[itemIndex].Currency.ToString()} gold"));
        }

        WriteLineMultiColored((ConsoleColor.Red, "---------"), (ConsoleColor.White, "PLAYER"),
            (ConsoleColor.Red, "---------"));
        WriteLineMultiColored((ConsoleColor.White, "Current currency: "), (ConsoleColor.Green, $"{activePlayer.Currency}"), (ConsoleColor.Green, "c"));
        Console.WriteLine("Enter [R] to return or enter the value of the item you wish to purchase!");
        Console.Write("Choice: ");
    }

    // public static void BuyFromShop(List<Item> shopStock, Character activePlayer)
    // {
    //     WriteLineMultiColored((ConsoleColor.Red, "---------"), (ConsoleColor.White, "BUY ITEM FROM SHOP"),
    //         (ConsoleColor.Red, "---------"));
    //     for (int itemIndex = 0; itemIndex < shopStock.Count; itemIndex++)
    //     {
    //         // Console.WriteLine($"[{itemIndex}]"); // {shopStock[itemIndex]}.Name}} - Buy for: {shopStock[itemIndex]}.Currency}}
    //         WriteLineMultiColored((ConsoleColor.Red, $"[{itemIndex}] "),
    //             (ConsoleColor.White, $"{shopStock[itemIndex].Name} - Cost: "),
    //             (ConsoleColor.Green, $"{shopStock[itemIndex].Currency.ToString()} gold"));
    //     }
    //
    //     WriteLineMultiColored((ConsoleColor.White, "Type"), (ConsoleColor.White, "\"r\" only"),
    //         (ConsoleColor.White, "and press ENTER to return."));
    //     WriteLineMultiColored((ConsoleColor.White, "Else, type the "), (ConsoleColor.Red, "index number"),
    //         (ConsoleColor.White, " of the item you like to buy below:"));
    // }

    public static void SellToShop(Character activePlayer)
    {
        WriteLineMultiColored((ConsoleColor.Red, "---------"), (ConsoleColor.White, "SELL ITEM TO SHOP"),
            (ConsoleColor.Red, "---------"));
        for (int itemIndex = 0; itemIndex < activePlayer.InventoryItems.Count; itemIndex++)
        {
            WriteLineMultiColored((ConsoleColor.Red, $"[{itemIndex}] "),
                (ConsoleColor.White, $"{activePlayer.InventoryItems[itemIndex].Name} - Cost: "),
                (ConsoleColor.Green, $"{activePlayer.InventoryItems[itemIndex].Currency.ToString()} gold"));
        }

        WriteLineMultiColored((ConsoleColor.White, "Current currency: "), (ConsoleColor.Green, $"{activePlayer.Currency}"), (ConsoleColor.Green, "c"));

        //Console.WriteLine($"Example: Your item {activePlayer.InventoryItems[1]}");
        WriteLineMultiColored((ConsoleColor.White, "Type "), (ConsoleColor.White, "\"[R]\" to return"));
        WriteLineMultiColored((ConsoleColor.White, "Otherwise, type the "), (ConsoleColor.Red, "index number"),
            (ConsoleColor.White, " of the item you like to sell below"));
        Console.Write("Choice: ");
    }

    public static void TutorialMenu()
    {
        WriteLineMultiColored((ConsoleColor.White, "Welcome to the "), (ConsoleColor.Red, "World of Heretics "),
            (ConsoleColor.White, "young adventurer!"));
        Console.WriteLine($"Outside the House of Tutorial you just witnessed the map of WoH.");
        WriteLineMultiColored((ConsoleColor.White, "In this map there´s"), (ConsoleColor.Red, " 4 structures "),
            (ConsoleColor.White, ", giving 4 different options;\n"));
        WriteLineMultiColored((ConsoleColor.Red, " - North West - "),
            (ConsoleColor.White, "Our in game Shop where you can buy "),
            (ConsoleColor.White, "and sell your looted items."));
        WriteLineMultiColored((ConsoleColor.Red, " - North East - "),
            (ConsoleColor.White, "The Mountain of adventures "), (ConsoleColor.White, "(to be released shortly)."));
        WriteLineMultiColored((ConsoleColor.Red, " - South West - "), (ConsoleColor.White, "Tutorial "),
            (ConsoleColor.White, "(Which house you just entered and found yourself in this text)"));
        WriteLineMultiColored((ConsoleColor.Red, " - South East - "),
            (ConsoleColor.White, "Fighting is where you´re able to encounter monsters, "),
            (ConsoleColor.White, "level up and loot items."));
        WriteLineMultiColored((ConsoleColor.Red, "[R]"), (ConsoleColor.White, "eturn "),
            (ConsoleColor.White, "to map."));
    }

    public static void MountainOutput()
    {
        Output.WriteLineMultiColored((ConsoleColor.Red, "BEWARE! The mountain is locked for now."),
            (ConsoleColor.White, "\nCheck back for future dlc"), (ConsoleColor.White, "!"));
        Output.WriteLineMultiColored((ConsoleColor.Red, "[R]"), (ConsoleColor.White, "eturn to "),
            (ConsoleColor.White, "map."));
    }

    public static void TutorialOutput()
    {
        //Console.WriteLine($"Welcome to the World of Heretics young adventurer!");
        //Console.WriteLine($"In this map there´s 4 areas with 4 different options;");
        //Console.WriteLine($" - North West - Our in game Shop where you can buy and sell your looted items.");
        //Console.WriteLine($" - North East - The Mountain of adventures (to be released shortly).");
        //Console.WriteLine($" - South West - Tutorial (Which house you just entered and found yourself in this text)");
        //Console.WriteLine($" - South East - Fighting is where you´re able to encounter monsters, level up and loot items.");
    }

    public static void FightingOptions(Character player)
    {
        Console.WriteLine(
            $"{player.Name}, you´ve defeated {player.FightEncounters} enemies so far, what´s your decision?");
        WriteLineMultiColored((ConsoleColor.Red, "[F]"), (ConsoleColor.White, "ight"), (ConsoleColor.White, "!"));
        WriteLineMultiColored((ConsoleColor.Red, "[R]"), (ConsoleColor.White, "un away and live to fight another day"),
            (ConsoleColor.White, "!"));
    }

    public static void FightingResult(Game game)
    {
        Console.WriteLine(game.HandleFighting(EnemyHandler.GetRandomEnemy(game.Player.LevelStats.Level)));
        Console.WriteLine("------------");
    }

    public static void FightWonOptions()
    {
        Console.WriteLine("You´ve defeated your enemy and won the battle!");
    }

    public static void FightLostOptions(Character player)
    {
        Console.WriteLine($"RIP {player.Name}, you´ve died and will have to restart your journey!");
        WriteLineMultiColored((ConsoleColor.Red, "[R]"), (ConsoleColor.White, "estart "),
            (ConsoleColor.White, "game."));
        WriteLineMultiColored((ConsoleColor.Red, "[Q]"), (ConsoleColor.White, "uit "), (ConsoleColor.White, "game."));
    }

    public static void Quit()
    {
        Console.WriteLine("Farewell young adventurer, your game is saved and we hope to see you soon!");
    }

    public static void TestRoamingMenu() // temporary fix for roaming map interactions
    {
        WriteLineMultiColored((ConsoleColor.Red, "---------"), (ConsoleColor.White, "ROAMING "),
            (ConsoleColor.Red, "---------"));
        Console.WriteLine("---------ROAMING---------");
        WriteLineMultiColored((ConsoleColor.Red, "[1.] "), (ConsoleColor.White, "Fight Club"),
            (ConsoleColor.White, "!"));
        WriteLineMultiColored((ConsoleColor.Red, "[2.] "), (ConsoleColor.White, "Shop"), (ConsoleColor.White, "!"));
        WriteLineMultiColored((ConsoleColor.Red, "[3.] "), (ConsoleColor.White, "Tutorial"), (ConsoleColor.White, "!"));
        WriteLineMultiColored((ConsoleColor.Red, "[4.] "), (ConsoleColor.White, "Leave"), (ConsoleColor.White, "!"));
    }

    public static void WriteLineMultiColored(params (ConsoleColor color, string value)[] values) //formatering för snyggare writes.
    {
        Console.Write("\r");
        foreach (var value in values)
        {
            Console.ForegroundColor = value.color;
            Console.Write(value.value);
        }

        Console.Write("\r\n");
        Console.ResetColor();
    }
}