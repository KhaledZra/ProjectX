namespace GameLogic;

public class Game // plumming code
{
    // this is where shit goes down
    private List<Item> _itemListDB;
    private List<Enemy> _enemyListDB;
    private Shop _shop;
    public Character _player;
    private Inventory _inventory;

    public Game(string playerName, string chosenClass)
    {
        _itemListDB = new(); // itemListDB temp but loadFromDB?
        _enemyListDB = new(); // enemyListDB temp but loadFromDB?
        _shop = new Shop();
        _player = new Character(playerName);
        _inventory = new Inventory(_player.Id);
        
        // use chosenClass to set class
        Skills.SetMelee(_player);
    }

    public bool HandleRoaming(int[,] map) // take input and create boundary rules
    {
        return true;
    }
    
    public string HandleFighting(Enemy enemy) // returns true if hero won else false
    {
        string battleInfo = $"------------\n" +
                            $"{_player.Name} VS {enemy.Name}" +
                            $"\n------------\n";
        int lostHearts = 0;
        //Console.WriteLine($"{_player.Name} vs {tempEnemy.Name}");

        while (true)
        {
            if (_player.Health <= 0) // checks if the Player died
            {
                battleInfo += $"{_player.Name} was defeated in battle... Shame!";
                return battleInfo;
            }
            enemy.Health -= 5; // Player strikes enemy!

            if (enemy.Health <= 0) // checks if the Enemy died
            {
                battleInfo += $"{enemy.Name} was defeated in battle! {_player.Name} will be rewarded!\n" +
                              $"Gained: {enemy.Level.Experience}xp!\n" +
                              $"Lost: {lostHearts} hearts, Hearts left: {_player.Health}\n";
                battleInfo += LevelUpHandler(enemy.Level.Experience);
                
                return battleInfo;
            }
            _player.Health -= 2; // Enemy strikes Player!
            lostHearts += 2;
        }
    }

    public string LevelUpHandler(int gainedExperience)
    {
        int levelsGained = _player.Level.GainExperience(gainedExperience);
                
        if (levelsGained == 1)
        {
            return $"{_player.Name} gained {levelsGained} Level\n{_player.Level.ToString()}";
        }
        else if (levelsGained >= 2)
        {
            return $"{_player.Name} gained {levelsGained} Levels\n{_player.Level.ToString()}";
        }
        else
        {
            return $"{_player.Name} gained no Levels\n{_player.Level.ToString()}";
        }
    }
}