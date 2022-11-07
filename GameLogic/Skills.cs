namespace GameLogic;
abstract class Skills 
{
    public static int Melee { get; set; } = 200;
    public static int Spell { get; set; } = 150;
    public static int Archer { get; set; } = 100;

    public static void SetMelee(Entity entity)
    {
        entity.Health = Melee;
    }

    public static void SetSpell(Entity entity)
    {
        entity.Health = Spell;
    }
    
    public static void SetArcher(Entity entity)
    {
        entity.Health = Archer;
    }
}