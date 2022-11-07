namespace GameLogic;
class Character : Entity
{
    public string GoodGuy { get; set; }

    public Character(string name, int id, int health, int level) : base(name, id, health, level)
    {
        
    }

}