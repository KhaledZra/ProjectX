namespace UserInterface;

public class DrawMap
{
    private static void RenderBackground(int bgStartx, int bgStarty, int bgEndX, int bgEndY)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        for (int i = bgStarty + 1; i < bgEndY; i++)
        {
            for (int j = bgStartx + 1; j < bgStartx + bgEndX; j++)
            {
                DrawThisAtXY("▒", j, i); //▒
            }
        }

        Console.ResetColor();
    }

    private static void RenderStructures() // map houses @ x/y/ with bannertext
    {
        //startingx sätter djup, startingy sätter höjd
        DrawWestWingHouse(5, 2, "FightClub"); //starting-x = 2 in från cursor, starting-y = 2 ner från 2,0
        DrawEastWingHouse(45, 10, "  Shop   ");
        DrawWestWingHouse(5, 10, " Tutorial");
        DrawNorthEastMountain(45, 2, "Mount Adv.");
        // DrawNorthEastMountainBig("HellTower", 45, 0, 60, 6);
        Console.ResetColor();
        DrawThisAtXY("", 0, 16);
    }

    private static void DrawWestWingHouse(int startingx, int startingy, string bannerSign)
    {
        //taket
        Console.ForegroundColor = ConsoleColor.DarkGray;
        for (int i = startingy; i < startingy + 1; i++) //höjden taket printas på
        {
            DrawThisAtXY(@"███████████", startingx,
                i); //from koordinat x = 10 in från vänster och bara på kordinat y som ovan
        }

        //banner
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        DrawThisAtXY(bannerSign, startingx + 1, startingy + 2); //djup in från vänster där banner startar
        Console.ResetColor();

        //vänster vägg av hus
        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = startingy + 1; i < startingy + 4; i++)
        {
            DrawThisAtXY("█", startingx, i);
        }

        Console.ForegroundColor = ConsoleColor.Red;
        //Filler på andra raden
        DrawThisAtXY("█████████", startingx + 1, startingy + 1);
        //höger vägg av hus
        for (int i = startingy + 1; i < startingy + 4; i++)
        {
            DrawThisAtXY("█", startingx + 10, i);
        }

        //Vägg jämte dörr
        Console.ForegroundColor = ConsoleColor.Red;
        DrawThisAtXY("█████████", startingx + 1, startingy + 3);

        //Dörrprint
        Console.ForegroundColor = ConsoleColor.DarkGray;
        DrawThisAtXY("██", startingx + 5, startingy + 3);
        Console.ResetColor();
    }

    private static void DrawEastWingHouse(int startingx, int startingy, string bannerSign)
    {
        //taket
        Console.ForegroundColor = ConsoleColor.DarkGray;
        for (int i = startingy; i < startingy + 1; i++) //höjden taket printas på
        {
            DrawThisAtXY(@"███████████", startingx,
                i); //from koordinat x = 10 in från vänster och bara på kordinat y som ovan
        }

        //banner
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        DrawThisAtXY(bannerSign, startingx + 1, startingy + 2); //djup in från vänster där banner startar
        Console.ResetColor();
        //vänster vägg av hus
        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = startingy + 1; i < startingy + 4; i++)
        {
            DrawThisAtXY("█", startingx, i);
        }

        //Filler på tredje rad
        DrawThisAtXY("█████████", startingx + 1, startingy + 1);
        //höger vägg av hus
        for (int i = startingy + 1; i < startingy + 4; i++)
        {
            DrawThisAtXY("█", startingx + 10, i);
        }

        //Vägg jämte dörr
        Console.ForegroundColor = ConsoleColor.Red;
        DrawThisAtXY("█████████", startingx + 1, startingy + 3);

        //Dörrprint
        Console.ForegroundColor = ConsoleColor.DarkGray;
        DrawThisAtXY("██", startingx + 4, startingy + 3);
    }

    private static void DrawNorthEastMountain(int startingx, int startingy, string bannerSign)
    {
        //taket
        Console.ForegroundColor = ConsoleColor.DarkGray;
        for (int i = startingy; i < startingy + 1; i++) //höjden taket printas på
        {
            DrawThisAtXY(@"███████████", startingx,
                i); //from koordinat x = 10 in från vänster och bara på kordinat y som ovan
        }

        //banner
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.White;
        DrawThisAtXY(bannerSign, startingx + 1, startingy + 2); //djup in från vänster där banner startar
        Console.ResetColor();
        //vänster vägg av hus
        Console.ForegroundColor = ConsoleColor.DarkGray;
        for (int i = startingy + 1; i < startingy + 4; i++)
        {
            DrawThisAtXY("█", startingx, i);
        }

        //Filler på tredje rad
        DrawThisAtXY("█████████", startingx + 1, startingy + 1);
        //höger vägg av hus
        for (int i = startingy + 1; i < startingy + 4; i++)
        {
            DrawThisAtXY("█", startingx + 10, i);
        }

        //Vägg bakom dörr
        Console.ForegroundColor = ConsoleColor.DarkGray;
        DrawThisAtXY("█████████", startingx + 1, startingy + 3);
        //Dörrprint
        Console.ForegroundColor = ConsoleColor.Black;
        DrawThisAtXY("██", startingx + 4, startingy + 3);
    }

    private static void DrawExitArea(int exitBaseX, int exitBaseY, int exitLayerX, int exitLayerY)
    {
        /*Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        DrawThisAtXY("█░░░░░░█", exitBaseX, exitBaseY); //DrawThisAtXY-EXIT ░*/
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        DrawThisAtXY("▒ EXIT ▒", exitLayerX, exitLayerY);
        Console.ResetColor();
    }
}