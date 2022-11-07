namespace GameLogic;
class Shop
{
    public int Stock { get; set; }
    public int Currency { get; set; }

    public Shop(int stock, int currency)
    {
        this.Stock = stock;
        this.Currency = currency;
    }

    public override string ToString()
    {
        return $"{Stock} {Currency}";
    }
}