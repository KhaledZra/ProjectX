namespace GameLogic;

class Item : Entity
{
    private List<Entity> itemList = new();

    public Item(string name, int id, int health, int level) : base(name, id, health, level)
    {
        
    }
}