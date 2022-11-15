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

            case GameState.CharacterHandler: // klar
                Output.CharacterHandlerOutPut();
                gameState = Input.CharacterMenuInput();
                break;

            case GameState.LoadCharacter: // inte klar än
                Console.WriteLine("Load feature not implemented yet!");
                gameState = GameState.CharacterHandler;
                break;

            case GameState.SetCharacterVocation: // Klar
                Output.ChooseCharacterVocation();
                gameState = Input.CharacterVocationInput(game._player);
                break;

            case GameState.SetCharacterName: // Klar
                Output.CharacterName();
                gameState = Input.CharacterNameInput(game._player);
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
                Output.WriteLineMultiColored((ConsoleColor.White, "The mountain is locked for now"), (ConsoleColor.White, "\nCheck back for release"), (ConsoleColor.White, "!"));
                Output.WriteLineMultiColored((ConsoleColor.Red, "[R]eturn "), (ConsoleColor.White, "to "), (ConsoleColor.White, "map."));
                //Console.WriteLine("The mountain is locked for you mortal.");
                //Console.WriteLine("[R]eturn");
                Console.ReadKey(true);
                Console.Clear();
                gameState = GameState.RoamingMap;
                // Returns GameState.TutorialMenu, GameState.ShopMenu, GameState.FightingMenu or GameState.Quit
                break;

            case GameState.ShopMenu: // inte klar än
                Output.ShopMenu();
                gameState = Input.ShopMenuInput();
                break;

            case GameState.BuyFromShop: // inte klar än
                Output.BuyFromShop(Shop.Stock.ToList());
                gameState = Input.ShopBuyMenuInput();
                break;

            case GameState.SellToShop: // inte klar än
                Output.SellToShop(game._player);
                gameState = Input.ShopSellMenuInput();
                break;

            case GameState.TutorialMenu: // inte klar än
                Output.TutorialMenu(game._player);
                gameState = Input.TutorialMenuInput();
                break;

            case GameState.FightMenu: // inte klar än, behöver hantera när man vinner
                Output.FightStartMenu(game._player);
                gameState = Input.FightingMenuInput();
                // Returns GameState.RoamingMap, GameState.WonMenu or LostMenu
                break;

            case GameState.Fighting: // inte klar än
                Output.FightingMenu(game);
                if (game._player.Health <= 0)
                {
                    gameState = GameState.LostMenu;
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

            case GameState.WonMenu: // inte klar än
                Output.WonMenu();
                gameState = GameState.QuitGame;
                break;

            case GameState.LostMenu: // inte klar än
                Output.LoseMenu(game._player);
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