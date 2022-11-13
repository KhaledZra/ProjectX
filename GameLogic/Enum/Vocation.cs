namespace GameLogic.Enum;

public class Vocation
{
    public VocationType VocationType { get; set; }
}

public enum VocationType
{
    Archer, // playable
    Berserker, // MONSTER
    Boss, // MONSTER
    God, // GM-state, eventually endGameBossMode - The triad of Ohm/Khal/Oxh = "Ohm, Khal, Oxh, The neverending trinity"
    Necromancer, // playable
    //Warrior, // playable
    Wizard // playable
}