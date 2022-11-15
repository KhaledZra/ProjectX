namespace GameLogic;
public class Shop
{
    public static List<Item> Stock { get; set; }
    public int Currency { get; set; }

    public Shop()
    {
        Stock = new List<Item>();
        this.Currency = 100000000; // Shop starts with 100 gold
    }

    public override string ToString()
    {
        return $"{Stock} - Prize: {Currency}";
    }
}