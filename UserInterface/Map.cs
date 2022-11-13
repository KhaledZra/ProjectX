namespace UserInterface;

public class Map
{
    public int[,] _twoDMap;
    public List<Structure> gameStructures = new List<Structure>();

    public Map(int xWidth, int xHeight)
    {
        _twoDMap = new int[xWidth, xHeight];
        SetupMap();
        Grid.CreateGrid(_twoDMap);
        gameStructures.Add(new Structure(_twoDMap, StructureType.Shop, 6, 6, 5, 6, true));
        gameStructures.Add(new Structure(_twoDMap, StructureType.Mountain, 20, 0, 11, 12, false));
        gameStructures.Add(new Structure(_twoDMap, StructureType.Tutorial, 6, 20, 5, 6, true));
        gameStructures.Add(new Structure(_twoDMap, StructureType.Fighting, 20, 20, 5, 6, false));
    }

    private void SetupMap()
    {
        for (int y = 0; y < _twoDMap.GetLength(1); y++)
        {
            for (int x = 0; x < _twoDMap.GetLength(0); x++)
            {
                _twoDMap[x, y] = 1;
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

        foreach (var structure in gameStructures)
        {
            structure.SetupStructureSign(_twoDMap);
        }
    }

    public void ColorizeMap(int y, int x)
    {
        if (_twoDMap[x, y] == 0) // is not roamable
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("O0O");
            Console.ResetColor();
        }
        else if (_twoDMap[x, y] == 1) //gräs1 - is roamable
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("wWw");
            Console.ResetColor();
        }
        else if (_twoDMap[x, y] == 2) // is not roamable
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("---");
            Console.ResetColor();
        }
        else if (_twoDMap[x, y] == 3) //is not roamable
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("   ");
            Console.ResetColor();
        }
        else if (_twoDMap[x, y] == 4) //is not roamable
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.ResetColor();
        }
        // else if (_twoDMap[x, y] == 5) //is not roamable // label
        // {
        //     Console.BackgroundColor = ConsoleColor.White;
        //     Console.ForegroundColor = ConsoleColor.White;
        //     Console.Write("Shop");
        //     Console.ResetColor();
        // }
        else

        {
            Console.Write("www");
        }
    }
}