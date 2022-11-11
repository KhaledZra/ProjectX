namespace UserInterface;

public class Map
{
    public int[,] _twoDMap;
    public int [,] _twoDHouse;
    public Map(int xLength, int yLength)
    {
        _twoDMap = new int[xLength, yLength];
        _twoDHouse = new int[xLength, yLength];
        SetupMap();
    }

    private void SetupMap()
    {
        for (int y = 0; y < _twoDMap.GetLength(1); y++)
        {
            for (int x = 0; x < _twoDMap.GetLength(0); x++)
            {
                _twoDMap[y, x] = 0;
            }
        }
    }
    
    public void ShowMap()
    {
        for (int y = 0; y < _twoDMap.GetLength(1); y++)
        {
            for (int x = 0; x < _twoDMap.GetLength(0); x++)
            {
                ColorizeMap(y, x);
            }

            Console.Write("\n");
        }
    }
    public void ColorizeMap(int y, int x)
    {
        if (_twoDMap[y, x] == 1)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("O0O");
            Console.ResetColor();
        }
        else if (_twoDMap[y, x] == 0)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("wWw");
            Console.ResetColor();
        }
        else
        {
            Console.Write("www");
        }
    }
    public void SetupHouse()
    {
        
        
        
    }

}