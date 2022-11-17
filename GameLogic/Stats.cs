namespace GameLogic;

public abstract class Stats
{
    private static int _archerHp = 125;
    private static int _mageHp = 125;
    private static int _warriorHp = 150;


    public static void SetWarrior(Character entity)
    {
        entity.Health = _warriorHp; //150
        entity.MaxHp = _warriorHp; //150
    }

    public static void SetMage(Character entity)
    {
        entity.Health = _mageHp; //125
        entity.MaxHp = _mageHp; //125
    }

    public static void SetArcher(Character entity)
    {
        entity.Health = _archerHp; //125
        entity.MaxHp = _archerHp; //125
    }
}