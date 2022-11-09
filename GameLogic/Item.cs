namespace GameLogic;

class Item : Entity
{
    private List<Entity> itemList = new();

    public Item(string name) : base(name)
    {
        
    }
}