namespace GameLogic;

public class Inventory
{
    private int _belongsToID;
    public int Amount { get; set; } = 0;
    public int Capacity { get; set; } = 0;
    public int MaxStackValue { get; set; } = 0;
    public List<Item> Items { get; set; }

    public Inventory(int belongsToId)
    {
        Items = new List<Item>();
        _belongsToID = belongsToId;
    }
}