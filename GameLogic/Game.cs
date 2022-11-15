namespace GameLogic;

public class Game // plumming code
{
    // this is where shit goes down
    private List<Item> _itemListDB;
    private List<Enemy> _enemyListDB;
    public Shop Shop;
    public Character _player;
    public static Inventory Inventory;

    public Game(string playerName, string chosenClass)
    {
        _itemListDB = new(); // itemListDB temp but loadFromDB?
        _enemyListDB = new(); // enemyListDB temp but loadFromDB?
        Shop = new Shop();
        _player = new Character(playerName);
        Inventory = new Inventory(_player.Id);

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

            enemy.Health -= _player.DealDamage(); // Player strikes enemy!

            if (enemy.Health <= 0) // checks if the Enemy died
            {
                battleInfo += $"{enemy.Name} was defeated in battle! {_player.Name} will be rewarded!\n" +
                              $"Gained: {enemy.LevelStats.Experience}xp!\n" +
                              $"Lost: {lostHearts} hearts, Hearts left: {_player.Health}\n";
                battleInfo += LevelUpHandler(enemy.LevelStats.Experience);

                return battleInfo;
            }

            _player.Health -= enemy.DealDamage(); // Enemy strikes Player!
            lostHearts += enemy.DealDamage(); // used to show result of fight
        }
    }

    public string LevelUpHandler(int gainedExperience)
    {
        int levelsGained = _player.LevelStats.GainExperience(gainedExperience);

        if (levelsGained == 1)
        {
            return $"{_player.Name} gained {levelsGained} Level\n{_player.LevelStats.ToString()}";
        }
        else if (levelsGained >= 2)
        {
            return $"{_player.Name} gained {levelsGained} Levels\n{_player.LevelStats.ToString()}";
        }
        else
        {
            return $"{_player.Name} gained no Levels\n{_player.LevelStats.ToString()}";
        }
    }
}