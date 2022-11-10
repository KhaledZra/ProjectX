namespace UserInterface;

public class GameStateHandler
{

    public static GameState SwitchMenu(GameState gameState)
    {
        // while (true) // ta bort loopen
        // {
        //     // Ta bort detta
        //     // Console.Clear();
        //     // Console.WriteLine("Menu");
        //     // Console.WriteLine("\n[1]MainMenu");
        //     // Console.WriteLine("[2]DrawRoaming");
        //     // Console.WriteLine("[3]ShopMenu");
        //     // Console.WriteLine("[4]TutorialMenu");
        //     // Console.WriteLine("[5]FightingMenu");
        //     // Console.WriteLine("[6]WonMenu");
        //     // Console.WriteLine("[7]WonMenu");
        //     //
        //     // char ch = Convert.ToChar(Console.ReadLine());
        //     // Console.Clear();
        //     
        //
        //     // behövs inte
        //     // Console.WriteLine("Press any key to Continue");
        //     // Console.ReadKey(true);
        // }
        
        Console.Clear();
        
        switch (gameState)
        {
            case GameState.MainMenu:
                MenuOutput.MainMenu(); // If user decides to quit return GameState.Quit
                // Return GameState.QuitGame;?
                // if gameState = GameState.QuitGame;
                // break;
                MenuOutput.CharacterMenu();
                MenuOutput.CharacterName();
                MenuOutput.ChooseCharacterClass();
                // Returns GameState.RoamingMap
                break;

            case GameState.RoamingMap:
                Console.WriteLine("----walking around----");
                Console.WriteLine("----walking around----");
                Console.WriteLine("----walking around----");
                // Returns GameState.TutorialMenu, GameState.ShopMenu, GameState.FightingMenu or GameState.Quit
                break;

            case GameState.ShopMenu:
                MenuOutput.ShopMenu();
                gameState = Input.ShopMenuInput();
                break;

            case GameState.TutorialMenu:
                // Switch on GameState.TutorialMenu
                MenuOutput.TutorialMenu();
                // Returns GameState.RoamingMap
                break;

            case GameState.FightingMenu:
                // Switch on GameState.FigtingMenu
                MenuOutput.FightingMenu();
                // Returns GameState.RoamingMap, GameState.WonMenu or LostMenu
                break;

            case GameState.WonMenu:
                // Switch on GameState.WonMenu
                MenuOutput.WonMenu();
                // Returns GameState.Quit
                break;

            case GameState.LostMenu:
                // Switch on GameState.WonMenu
                MenuOutput.LooseMenu();
                // Returns GameState.Quit
                break;
        }

        return gameState;
    }
}