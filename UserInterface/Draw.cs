//Klassen draws enda uppgift är att knyta samman GameStateHandler(Enum), Alla "fysiska" entiteter(grid,map,structures)
//fysiska entiteter - dvs det vi kan röra oss/inte röra oss på, såsom grid,gridLine samt structures = hus/berg/whatever
//varje enskild klass kan

using System.Reflection;

namespace UserInterface;

using GameLogic;

public class Draw
{
    public Map map;
    private static (int, int) _oldPlayerCoords;

    public Draw(Character player)
    {
        map = new Map(96, 32); // scaled to 3:1 aspect ratio
        _oldPlayerCoords.Item1 = player.CoordX;
        _oldPlayerCoords.Item2 = player.CoordY;
    }
    
    public void DrawMap()
    {
        map.ShowMap();
    }

    private static void CleanUpOldPlayerDraw()
    {
        (int, int) oldCoords = Console.GetCursorPosition();
        Console.SetCursorPosition(_oldPlayerCoords.Item1, _oldPlayerCoords.Item2);
        DrawGrass();
        Console.SetCursorPosition(oldCoords.Item1, oldCoords.Item2);
    }

    public static void DrawPlayer(Character player)
    {
        CleanUpOldPlayerDraw();
        WriteAt("@", player.CoordX, player.CoordY);
        _oldPlayerCoords.Item1 = player.CoordX;
        _oldPlayerCoords.Item2 = player.CoordY;
    }

    public static void DrawGrass()
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("w");
        Console.ResetColor();
    }

    public static void DrawGridWall()
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("0");
        Console.ResetColor();
    }
    
    public static void DrawHouseTile()
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
    }
    public static void DrawMountainTile()
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(" ");
        Console.ResetColor();
    }

    public static void DrawHouseDoor()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(" ");
        Console.ResetColor();
    }
    
    private static void WriteAt(string text, int x, int y)
    {
        (int, int) oldCoords = Console.GetCursorPosition();
        Console.SetCursorPosition(x, y);
        Console.Write(text);
        Console.SetCursorPosition(oldCoords.Item1, oldCoords.Item2);
    }
}


