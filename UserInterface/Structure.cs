namespace UserInterface;

public class Structure
{
    public int[,] _twoDHouse;
    
    public int XWidth { get; set; }
    
    public int YHeight { get; set; }
    public int StarterX { get; set; }
    public int StarterY { get; set; }
    public StructureType StructureType { get; set; }
    public bool IsFacingRight { get; set; }


    public Structure(int[,] twoDMap, StructureType structureType, int starterX, int starterY, int xWidth, int yHeight,
        bool isfacingright)
    {
        IsFacingRight = isfacingright;
        StarterX = starterX;
        StarterY = starterY;
        XWidth = xWidth;
        YHeight = yHeight;
        StructureType = structureType;
        SetupStructure(xWidth, yHeight, twoDMap);
        SetupDoorStructure(xWidth, yHeight, twoDMap);
    }

    private void SetupStructure(int xwidth, int yheight, int[,] twoDMap)
    {
        for (int y = StarterY; y < StarterY + yheight; y++)
        {
            for (int x = StarterX; x < StarterX + xwidth; x++)
            {
                if (this.StructureType == StructureType.Mountain)
                {
                    twoDMap[x, y] = 3;
                }
                else
                {
                    twoDMap[x, y] = 2;
                }
            }
        }
    }

    private void SetupDoorStructure(int xwidth, int yheight, int[,] twoDMap)
    {
        int DoorX;
        if (IsFacingRight)
        {
            DoorX = StarterX + (xwidth / 2);
        }
        else
        {
            DoorX = StarterX + (xwidth / 2) - 1;
        }

        int DoorY = StarterY + yheight;
        int DoorWidth = DoorX + 2;
        int DoorHeight = DoorY - 2;

        for (int x = DoorX; x < DoorWidth; x++)
        {
            for (int y = DoorHeight; y < DoorY; y++)
            {
                twoDMap[x, y] = 4;
            }
        }

        /*
        private void SetupStructureSign(int xwidth, int yheight, int[,] twoDMap, StructureType structureSign)
        {
            
            
        }
        */

        //add gray beneath doorsstructure
    }
    public void SetupStructureSign(int[,] twoDMap)
    {
        int labelStarterY = StarterY + (YHeight/2) - 1;
        int labelXStart = StarterX;
        int labelXEnd = StarterX + XWidth;

        // for (int x = labelXStart; x < labelXEnd; x++)
        // {
        //     twoDMap[x, labelStarterY] = 5;
        // }
        var currentLocation = Console.GetCursorPosition();
        Console.SetCursorPosition(StarterX * 3 + XWidth-2, labelStarterY);
        Console.Write(StructureType.ToString());
        Console.SetCursorPosition(currentLocation.Left, currentLocation.Top);
    }
}

public enum StructureType
{
    Unassigned,
    Shop,
    Tutorial,
    Mountain,
    Fighting,
    Exit
}