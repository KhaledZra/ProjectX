namespace GameLogic;
abstract class Skills 
{
    private static int _melee = 200;
    private static int _spell = 150;
    private static int _archer = 100;

    public static void SetMelee(Entity entity)
    {
        entity.Health = _melee;
    }

    public static void SetSpell(Entity entity)
    {
        entity.Health = _spell;
    }
    
    public static void SetArcher(Entity entity)
    {
        entity.Health = _archer;
    }
}