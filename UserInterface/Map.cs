namespace UserInterface;

public class Map
{
    public int[,] TwoDMap { get; set; }
    public List<Structure> gameStructures = new List<Structure>();

    public Map(int xWidth, int xHeight)
    {
        // Map setup
        TwoDMap = new int[xWidth, xHeight];
        SetupMap();
        Grid.CreateGrid(TwoDMap);

        // Structure setup
        SetupStructures();
    }

    private void SetupMap()
    {
        for (int y = 0; y < TwoDMap.GetLength(1); y++)
        {
            for (int x = 0; x < TwoDMap.GetLength(0); x++)
            {
                TwoDMap[x, y] = 1;
            }
        }
    }

    private void SetupStructures()
    {
        gameStructures.Add(new Structure(TwoDMap, GameState.Shop,
            TwoDMap.GetLength(0) / 7, 6, TwoDMap.GetLength(0) / 4, 6,
            true));

        gameStructures.Add(new Structure(TwoDMap, GameState.Mountain,
            TwoDMap.GetLength(0) / 2, 0, TwoDMap.GetLength(0) / 2, 12,
            false));

        gameStructures.Add(new Structure(TwoDMap, GameState.Tutorial,
            TwoDMap.GetLength(0) / 7, 20, TwoDMap.GetLength(0) / 4, 6,
            true));

        gameStructures.Add(new Structure(TwoDMap, GameState.Arena,
            TwoDMap.GetLength(0) / 2, 20, TwoDMap.GetLength(0) / 4, 6,
            false));

        gameStructures.Add(new Structure(TwoDMap, GameState.QuitGame,
            1, 1, 13,
                3, false));
    }

    public void ShowMap()
    {
        for (int y = 0; y < TwoDMap.GetLength(1); y++)
        {
            for (int x = 0; x < TwoDMap.GetLength(0); x++)
            {
                VisualizeMap(x, y);
            }

            Console.Write("\n");
        }

        foreach (var structure in gameStructures)
        {
            structure.SetupStructureSign(TwoDMap);
        }
    }

    public void VisualizeMap(int x, int y)
    {
        if (TwoDMap[x, y] == 0) // is not roamable
        {
            Draw.DrawGridWall();
        }
        else if (TwoDMap[x, y] == 1) // is roamable
        {
            Draw.DrawGrass();
        }
        else if (TwoDMap[x, y] == 2) // is not roamable
        {
            Draw.DrawHouseTile();
        }
        else if (TwoDMap[x, y] == 3) // is not roamable
        {
            Draw.DrawMountainTile();
        }
        else
        {
            Draw.DrawHouseDoor();
        }
    }
}