namespace MainProgram;

using UserInterface;
using GameLogic;
class Program
{
    public static void Main(string[] args)
    {
        GameState gameState = GameState.MainMenu;
        Game game = new Game("Khaled", "Warrior");
        
        Console.Clear();
        Console.CursorVisible = false;
        while (gameState != GameState.ExitProgram)
        {
            gameState = GameStateHandler.SwitchMenu(gameState, game);
        }
    }
}