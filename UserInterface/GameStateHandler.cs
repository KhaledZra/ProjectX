namespace UserInterface;

using GameLogic;

public class GameStateHandler
{
    public static GameState SwitchMenu(GameState gameState, Game game)
    {
        Draw draw = new Draw(game._player); // används för att rita map/spelare

        switch (gameState)
        {
            case GameState.MainMenu: // klar
                Output.MainMenu();
                gameState = Input.MainMenuInput();
                break;

            case GameState.CharacterOptions: // klar
                Output.CharacterHandlerOutPut();
                gameState = Input.CreateNewCharacter();
                break;

            case GameState.LoadCharacter: // inte klar än
                Console.WriteLine("Load feature not implemented yet!");
                gameState = GameState.CharacterOptions;
                break;

            case GameState.CreateCharacter: // Klar
                Output.ChooseCharacterVocation();
                gameState = Input.SetCharacterVocation(game._player);
                break;

            case GameState.VocSetPickName: // Klar
                Output.CharacterName(game._player.Vocation);
                gameState = Input.SetCharacterName(game._player);
                break;

            case GameState.RoamingMap: // inte klar, behöver exit.
                draw.DrawMap();
                while (gameState == GameState.RoamingMap)
                {
                    Draw.DrawPlayer(game._player);
                    gameState = Input.MovePlayerInput(game._player, draw.map);
                }

                Console.Clear();
                // Returns GameState.TutorialMenu, GameState.ShopMenu, GameState.FightingMenu or GameState.Quit
                break;

            case GameState.Mountain: // DLC, kanske tars bort helt sen
                Output.WriteLineMultiColored((ConsoleColor.Red, "BEWARE! The mountain is locked for now."),
                    (ConsoleColor.White, "\nCheck back for future dlc"), (ConsoleColor.White, "!"));
                Output.WriteLineMultiColored((ConsoleColor.Red, "[R]eturn "), (ConsoleColor.White, "to "),
                    (ConsoleColor.White, "map."));
                //Console.WriteLine("The mountain is locked for you mortal.");
                //Console.WriteLine("[R]eturn");
                Console.ReadKey(true);
                Console.Clear();
                gameState = GameState.RoamingMap;
                // Returns GameState.TutorialMenu, GameState.ShopMenu, GameState.FightingMenu or GameState.Quit
                break;

            case GameState.Shop: // inte klar än
                Output.ShopMainMenu();
                gameState = Input.GetFromShopMenu();
                break;

            case GameState.Browsing: // inte klar än
                Output.StockInShop(game.Shop._stockInShop);//Shop.Stock.ToList()
                gameState = Input.ItemInStock();
                break;

            case GameState.Selling: // inte klar än
                Output.SellToShop(game._player);
                gameState = Input.SellInventory();
                break;

            case GameState.Tutorial: // inte klar än
                Output.TutorialMenu(game._player);
                gameState = Input.TutorialMenu();
                break;

            case GameState.Arena: // inte klar än, behöver hantera när man vinner
                Output.FightingOptions(game._player);
                gameState = Input.FightingMenu();
                // Returns GameState.RoamingMap, GameState.WonMenu or LostMenu
                break;

            case GameState.Fighting: // inte klar än
                Output.FightingResult(game);
                if (game._player.Health <= 0)
                {
                    gameState = GameState.LostFight;
                }
                // else if (//won condition)
                // {
                //     
                // }
                else
                {
                    gameState = GameState.Arena;
                }

                break;

            case GameState.WonFight: // inte klar än
                Output.FightWonOptions();
                gameState = GameState.QuitGame;
                break;

            case GameState.LostFight: // inte klar än
                Output.FightLostOptions(game._player);
                gameState = GameState.QuitGame;
                break;

            case GameState.QuitGame: // inte klar än, behöver spara osv
                Output.Quit();
                gameState = GameState.ExitProgram;
                break;
        }

        return gameState;
    }
}