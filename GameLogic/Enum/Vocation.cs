namespace GameLogic;

public enum Vocation
{
    Archer, // playable
    Warrior, // playable
    Mage, // playable
    
    Berserker, // non-playable
    Boss, // non-playable
    Necromancer, // non-playable
   
    God // GM-state, eventually endGameBossMode - The triad of Ohm/Khal/Oxh = "Ohm, Khal, Oxh, The neverending trinity"
}