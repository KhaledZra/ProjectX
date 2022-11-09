namespace UserInterface;
//Ska grid "stänga in/hålla ute" -dvs zones en spelare ej kan befinna sig på?
public class DrawGrid
{
    private static void RenderGrid() //Grid size set
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        // Topp grid line
        DrawThisAtXY("█", 60, 15);
        for (int i = 1; i < 60; i++)
        {
            DrawThisAtXY("█", i, 0);
        }

        // Left grid line
        DrawThisAtXY("█", 0, 0);
        for (int i = 1; i < 15; i++)
        {
            DrawThisAtXY("█", 0, i);
        }

        // Bottom grid
        DrawThisAtXY("█", 60, 15);
        for (int i = 0; i < 60; i++) //bestämmer hur långt detta ska skrivas ut from X = 0/i
        {
            DrawThisAtXY("█", i, 15);
        }

        // Right grid
        DrawThisAtXY("█", 60, 0);
        for (int i = 1; i < 15; i++)
        {
            DrawThisAtXY("█", 60, i); //x ställer bredd på right grid
        }

        Console.ResetColor();
    }
}