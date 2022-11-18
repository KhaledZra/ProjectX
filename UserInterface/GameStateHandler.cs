namespace UserInterface;

using GameLogic;

public class GameStateHandler
{
    public static GameState SwitchMenu(GameState gameState, Game game)
    {
        Draw draw = new Draw(game.Player); // används för att rita map/spelare
        
        switch (gameState)
        {
            case GameState.MainMenu: return MainMenuState();
            case GameState.CharacterOptions: return CharacterOptionState();
            case GameState.LoadCharacter: return LoadCharacterState();
            case GameState.CreateCharacter: return PickVocationState(game.Player);
            case GameState.VocSetPickName: return VocSetPickNameState(game.Player);
            case GameState.RoamingMap: return RoamingState(draw, game.Player, gameState);
            case GameState.Mountain: return MountainState(); // DLC, kanske tars bort helt sen?
            case GameState.Shop: return ShopState(); // inte klar än
            case GameState.Browsing: return ShopBrowsingState(game.Shop); // inte klar än
            case GameState.Selling: return ShopSellingState(game.Player); // inte klar än
            case GameState.Tutorial: return TutorialState();
            case GameState.Arena: return ArenaState(game.Player);
            case GameState.Fighting: return FightingState(game); // inte klar än, Behöver hantera win condition (om de ska vara possible)
            case GameState.WonFight: return WonState(); // inte klar än
            case GameState.LostFight: return LoseState(game.Player); // inte klar än, behöver hanteras bättre
            case GameState.QuitGame: return QuitState(); // inte klar än, behöver spara osv
            default:
                Console.WriteLine("Something went wrong!");
                return GameState.QuitGame;
        }
    }
    
    private static GameState MainMenuState()
    {
        Output.MainMenu();
        return Input.MainMenuInput();
    }
    
    private static GameState CharacterOptionState()
    {
        Output.CharacterHandlerOutPut();
        return Input.CreateNewCharacter();
    }
    
    private static GameState LoadCharacterState()
    {
        Console.WriteLine("Load feature not implemented yet!");
        return GameState.CharacterOptions;
    }
    
    private static GameState VocSetPickNameState(Character player)
    {
        Output.CharacterName(player.Vocation);
        return Input.SetCharacterName(player);

    }
    
    private static GameState PickVocationState(Character player)
    {
        Output.ChooseCharacterVocation();
        return Input.SetCharacterVocation(player);
    }

    private static GameState RoamingState(Draw draw, Character player, GameState gameState)
    {
        draw.DrawMap();
        draw.DrawPlayerInfo(player);
        while (gameState == GameState.RoamingMap)
        {
            Draw.DrawPlayer(player);
            gameState = Input.MovePlayerInput(player, draw.map);
        }
        Console.Clear();
        return gameState;
    }
    
    private static GameState TutorialState()
    {
        Output.TutorialMenu();
        return Input.TutorialMenu();
    }
    
    private static GameState MountainState()
    {
        Output.MountainOutput();
        return Input.MountainMenu();
    }
    
    private static GameState ShopState()
    {
        Output.ShopMainMenu();
        return Input.GetFromShopMenu();
    }
    
    private static GameState ShopBrowsingState(Shop shop)
    {
        Output.StockInShop(shop._stockInShop);
        return Input.ItemInStock();
    }
    
    private static GameState ShopSellingState(Character player)
    {
        Output.SellToShop(player);
        return Input.SellInventory();
    }
    
    private static GameState ArenaState(Character player)
    {
        Output.FightingOptions(player);
        return Input.FightingMenu();
    }
    
    private static GameState FightingState(Game game)
    {
        Output.FightingResult(game);
        if (game.Player.Health <= 0) return GameState.LostFight;
        // return GameState.Won; Ska man vinna eller inte?
        return GameState.Arena;
    }
    
    private static GameState WonState()
    {
        Output.FightWonOptions();
        return GameState.QuitGame;
    }
    
    private static GameState LoseState(Character player)
    {
        Output.FightLostOptions(player);
        return GameState.QuitGame;
    }
    
    private static GameState QuitState()
    {
        Output.Quit();
        return GameState.ExitProgram;
    }
}