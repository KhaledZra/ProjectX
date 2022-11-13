namespace UserInterface;

using GameLogic;

public class GameStateHandler
{
    public static GameState SwitchMenu(GameState gameState, Game game)
    {
        switch (gameState)
        {
            case GameState.MainMenu: // klar
                output.MainMenu();
                gameState = Input.MainMenuInput();
                break;

            case GameState.CharacterHandler: // klar
                output.CharacterHandlerOutPut();
                gameState = Input.CharacterMenuInput();
                break;
            
            case GameState.LoadCharacter: // inte klar än
                Console.WriteLine("Load feature not implemented yet!");
                gameState = GameState.CharacterHandler;
                break;
            
            case GameState.SetCharacterVocation: // inte klar än, behöver sätta vocation
                output.ChooseCharacterVocation();
                gameState = Input.CharacterVocationInput();
                break;
            
            case GameState.SetCharacterName: // inte klar än, behöver sätta namn
                output.CharacterName();
                gameState = Input.CharacterNameInput();
                break;

            case GameState.RoamingMap: // väntar på robert
                output.TestRoamingMenu();
                gameState = Input.TestRoamingMenuInput();
                // Returns GameState.TutorialMenu, GameState.ShopMenu, GameState.FightingMenu or GameState.Quit
                break;

            case GameState.ShopMenu: // inte klar än
                output.ShopMenu();
                gameState = Input.ShopMenuInput();
                break;

            case GameState.BuyFromShop: // inte klar än
                output.BuyFromShopMenu();
                gameState = Input.ShopBuyMenuInput();
                break;

            case GameState.SellInShop: // inte klar än
                output.SellInShop();
                gameState = Input.ShopSellMenuInput();
                break;

            case GameState.TutorialMenu: // inte klar än
                output.TutorialMenu();
                gameState = Input.TutorialMenuInput();
                break;

            case GameState.FightMenu: // inte klar än, behöver hantera när man vinner
                output.FightStartMenu();
                gameState = Input.FightingMenuInput();
                // Returns GameState.RoamingMap, GameState.WonMenu or LostMenu
                break;
            
            case GameState.Fighting: // inte klar än
                output.FightingMenu(game);
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
                output.WonMenu();
                gameState = GameState.QuitGame;
                break;

            case GameState.LostMenu: // inte klar än
                output.LooseMenu();
                gameState = GameState.QuitGame;
                break;

            case GameState.QuitGame: // inte klar än, behöver spara osv
                output.Quit();
                gameState = GameState.ExitProgram;
                break;
        }

        return gameState;
    }
}