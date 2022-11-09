namespace GameLogic;

public class Game // plumming code
{
    // this is where shit goes down
    private List<Item> _itemListDB;
    private List<Enemy> _enemyListDB;
    private Shop _shop;
    private Character _player;
    private Inventory _inventory;

    public Game(string playerName, string chosenClass)
    {
        _itemListDB = new(); // itemListDB temp but loadFromDB?
        _enemyListDB = new(); // enemyListDB temp but loadFromDB?
        _shop = new Shop();
        _player = new Character(playerName);
        _inventory = new Inventory(_player.Id);
        
        // set chosenClass to _player
    }
}