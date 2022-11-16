namespace UserInterface;

using GameLogic;

public class GameStateHandler
{
    public static GameState SwitchMenu(GameState gameState, Game game)
    {
        Draw draw = new Draw(game._player);

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

            case GameState.PickVocation: // Klar
                Output.ChooseCharacterVocation();
                gameState = Input.SetCharacterVocation(game._player);
                break;

            case GameState.PickName: // Klar
                Output.CharacterName();
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

            case GameState.InsideMountain: // DLC, kanske tars bort helt sen
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

            case GameState.InsideShop: // inte klar än
                Output.ShopMainMenu();
                gameState = Input.GetFromShopMenu();
                break;

            case GameState.BrowsingStock: // inte klar än
                Output.StockInShop();//Shop.Stock.ToList()
                gameState = Input.ItemInStock();
                break;

            case GameState.SellingToShop: // inte klar än
                Output.SellToShop(game._player);
                gameState = Input.SellInventory();
                break;

            case GameState.InsideTutorial: // inte klar än
                Output.TutorialMenu(game._player);
                gameState = Input.TutorialMenu();
                break;

            case GameState.FightMenu: // inte klar än, behöver hantera när man vinner
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
                    gameState = GameState.FightMenu;
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