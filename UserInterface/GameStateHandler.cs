namespace UserInterface;

using GameLogic;

public class GameStateHandler
{
    public static GameState SwitchMenu(GameState gameState, Game game)
    {
        Draw draw = new Draw(game.Player); // används för att rita map/spelare

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
                gameState = Input.SetCharacterVocation(game.Player);
                Character.SetCharacterVocationStats(game.Player);
                break;

            case GameState.VocSetPickName: // Klar
                Output.CharacterName(game.Player.Vocation);
                gameState = Input.SetCharacterName(game.Player);
                break;

            case GameState.RoamingMap: // inte klar, behöver exit.
                draw.DrawMap();
                draw.DrawPlayerInfo(game.Player);
                while (gameState == GameState.RoamingMap)
                {
                    Draw.DrawPlayer(game.Player);
                    gameState = Input.MovePlayerInput(game.Player, draw.map);
                }
                Console.Clear();
                // Returns GameState.TutorialMenu, GameState.ShopMenu, GameState.FightingMenu or GameState.Quit
                break;

            case GameState.Mountain: // DLC, kanske tars bort helt sen
                Output.MountainOutput();
                gameState = Input.MountainMenu();
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
                Output.SellToShop(game.Player);
                gameState = Input.SellInventory();
                break;

            case GameState.Tutorial: // klar
                Output.TutorialMenu(game.Player);
                gameState = Input.TutorialMenu();
                break;

            case GameState.Arena: // inte klar än, behöver hantera när man vinner
                Output.FightingOptions(game.Player);
                gameState = Input.FightingMenu();
                // Returns GameState.RoamingMap, GameState.WonMenu or LostMenu
                break;

            case GameState.Fighting: // inte klar än
                Output.FightingResult(game);
                if (game.Player.Health <= 0)
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
                Output.FightLostOptions(game.Player);
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