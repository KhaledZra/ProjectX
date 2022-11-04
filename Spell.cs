class Spell
{
    public string SpellName { get; set; }
    public int SpellDmg { get; set; }
    public int ManaCost { get; set; }
    public int SpellCritChance { get; set; }


    public Spell(string name, int spelldmg, int manacost, int spellcc)
    {
        SpellName = name;
        SpellDmg = spelldmg;
        ManaCost = manacost;
        SpellCritChance = spellcc;
    }

}