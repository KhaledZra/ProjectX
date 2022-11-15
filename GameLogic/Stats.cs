namespace GameLogic;

abstract class Stats
{
    private static int _archerHp = 125;
    private static int _mageHp = 125;
    private static int _warriorHp = 150;


    public static void SetWarrior(Entity entity)
    {
        entity.Health = _warriorHp; //200
    }

    public static void SetMage(Entity entity)
    {
        entity.Health = _mageHp; //150
    }

    public static void SetArcher(Entity entity)
    {
        entity.Health = _archerHp; //100
    }
}