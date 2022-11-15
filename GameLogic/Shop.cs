namespace GameLogic;
public class Shop
{
    public static List<Item> Stock { get; set; }
    public int Currency { get; set; }

    public Shop()
    {
        this.Stock = new List<Item>();
        this.Currency = 100; // Shop starts with 100 gold
    }

    public override string ToString()
    {
        return $"{Stock} {Currency}";
    }
}