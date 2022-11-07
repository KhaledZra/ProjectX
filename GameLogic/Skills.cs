namespace GameLogic;
class Skills 
{
    public int Melee { get; set; }
    public int Spell { get; set; }
    public int Archer { get; set; }

    public Skills(int melee, int spell, int archer)
    {

    }

    public override string ToString()
    {
        return $"{Melee} {Spell} {Archer}";
    }
}