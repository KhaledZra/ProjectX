namespace UserInterface;

public class Map
{
    public int[,] _twoDMap;
    public List<Structure> gameStructures = new List<Structure>();

    public Map(int xWidth, int xHeight)
    {
        // Map setup
        _twoDMap = new int[xWidth, xHeight];
        SetupMap();
        Grid.CreateGrid(_twoDMap);
        
        // Structure setup
        SetupStructures();
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

    private void SetupStructures()
    {
        gameStructures.Add(new Structure(_twoDMap, GameState.Shop,
            _twoDMap.GetLength(0)/7, 6, _twoDMap.GetLength(0)/4, 6,
            true));
        
        gameStructures.Add(new Structure(_twoDMap, GameState.Mountain,
            _twoDMap.GetLength(0)/2, 0, _twoDMap.GetLength(0)/2, 12,
            false));
        
        gameStructures.Add(new Structure(_twoDMap, GameState.Tutorial,
            _twoDMap.GetLength(0)/7, 20, _twoDMap.GetLength(0)/4, 6, 
            true));
        
        gameStructures.Add(new Structure(_twoDMap, GameState.Arena,
            _twoDMap.GetLength(0)/2, 20, _twoDMap.GetLength(0)/4, 6, 
            false));
    }

    public void ShowMap()
    {
        for (int y = 0; y < _twoDMap.GetLength(1); y++)
        {
            for (int x = 0; x < _twoDMap.GetLength(0); x++)
            {
                VisualizeMap(y, x);
            }

            Console.Write("\n");
        }

        foreach (var structure in gameStructures)
        {
            structure.SetupStructureSign(_twoDMap);
        }
    }

    public void VisualizeMap(int y, int x)
    {
        if (_twoDMap[x, y] == 0) // is not roamable
        {
            Draw.DrawGridWall();
        }
        else if (_twoDMap[x, y] == 1) // is roamable
        {
            Draw.DrawGrass();
        }
        else if (_twoDMap[x, y] == 2) // is not roamable
        {
            Draw.DrawHouseTile();
        }
        else if (_twoDMap[x, y] == 3) // is not roamable
        {
            Draw.DrawMountainTile();
        }
        else
        {
            Draw.DrawHouseDoor();
        }
        // else if (_twoDMap[x, y] == 9) // is interactable, Tutorial
        // {
        //     Draw.DrawHouseDoor();
        // }
        // else if (_twoDMap[x, y] == 11) // is interactable, fighting
        // {
        //     Draw.DrawHouseDoor();
        // }
        // else if (_twoDMap[x, y] == 6) // is interactable, shop
        // {
        //     Draw.DrawHouseDoor();
        // }
        // else if (_twoDMap[x, y] == 14) // is interactable, quit?
        // {
        //     Draw.DrawHouseDoor();
        // }
    }
}