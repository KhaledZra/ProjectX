namespace UserInterface;

public class GameStateHandler
{

    public static GameState SwitchMenu(GameState gameState)
    {
        Console.Clear();
        
        ConsoleKey input = Console.ReadKey().Key;
        
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
    
            case GameState.TutorialMenu:
                // Switch on GameState.TutorialMenu
                output.TutorialMenu();
                // Returns GameState.RoamingMap
                break;

            case GameState.FightingMenu:
                // Switch on GameState.FigtingMenu
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