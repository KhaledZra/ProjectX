namespace UserInterface;

public class GameStateHandler
{

    public static GameState SwitchMenu(GameState gameState)
    {
        switch (gameState)
        {
            case GameState.MainMenu:
                
                output.MainMenu();
                gameState = Input.MainMenuInput();
            
                break;
            
            case GameState.CharacterHandler:
                   
                 output.CharacterHandlerOutPut();
                 output.ChooseCharacterClass();
                 output.CharacterName();
                break;

            case GameState.RoamingMap:
                Console.WriteLine("----walking around----");
                Console.WriteLine("----walking around----");
                Console.WriteLine("----walking around----");
                // Returns GameState.TutorialMenu, GameState.ShopMenu, GameState.FightingMenu or GameState.Quit
                break;

            case GameState.ShopMenu:
                
                output.ShopMenu();
                gameState = Input.ShopMenuInput();
                break;

                case GameState.BuyFromShop:
        
                output.BuyFromShopMenu();
                gameState = Input.ShopMenuInput();
                break;

                case GameState.SellInShop:
                
                output.SellInShop();
                gameState = Input.ShopMenuInput();
                break;
    
            case GameState.TutorialMenu:
                
                output.TutorialMenu();
                gameState = Input.TutorialMenuInput();
                break;

            case GameState.FightingMenu:
              
                output.FightingMenu();
                // Returns GameState.RoamingMap, GameState.WonMenu or LostMenu
                break;

            case GameState.WonMenu:
                // Switch on GameState.WonMenu
                output.WonMenu();
                // Returns GameState.Quit
                break;

            case GameState.LostMenu:
                // Switch on GameState.WonMenu
                output.LooseMenu();
                // Returns GameState.Quit
                break;
            
            case GameState.QuitGame:

                
                output.Quit();
            break;
        }

        return gameState;
    }
}