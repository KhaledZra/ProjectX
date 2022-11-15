namespace MainProgram;

using UserInterface;
using GameLogic;

class Program
{
    /*
    Item item = new Item();
    */

    public static void Main(string[] args)
    {
        /*Map map = new Map(32, 32);
        map.ShowMap();*/


//        Item.GetShopItems(shopItems);
        /*
        foreach (var item in (Item.GetAllItems()))
            Console.WriteLine(Item.ToString());
            */

        // Console.WriteLine(item.Name, item.LevelStats.ToString());
        /*GameState gameState = GameState.ShopMenu;
        Game game = new Game("Khaled", "Warrior");

        while (gameState != GameState.QuitGame)
        {
            gameState = GameStateHandler.SwitchMenu(gameState);
        }*/
        
        //Omars feature
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