namespace GameLogic;
public class Inventory
{
    private int _belongsToID;
    public int Amount { get; set; } = 0;
    public int Capacity { get; set; } = 0;
    public int MaxStackValue { get; set; } = 0;

    public Inventory(int belongsToId)
    {
        _belongsToID = belongsToId;
    }
}