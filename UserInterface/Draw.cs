using System.Diagnostics.Tracing;
using System.Xml;
using System.Text;

namespace UserInterface;
//run in high contrast theme preferably

struct TwoOCoords //two coordinates flera variabler i en variabler, används ofta för koordinater
    //bättre såhär så man kan välja namnet ist för (int, int)
{
    public int x { get; set; }
    public int y { get; set; }
}
    
struct LastPlayerCoords //two coordinates flera variabler i en variabler, används ofta för koordinater
    //bättre såhär så man kan välja namnet ist för (int, int)
{
    public int x { get; set; }
    public int y { get; set; }
}
public class Draw
{
    private static LastPlayerCoords _lastPlayerCoords = new LastPlayerCoords();

    static void DrawThisAtXY(string text, int x, int y)
    {
        Console.SetCursorPosition(x, +y);
        Console.Write(text);
    }

    public static void RenderMap()
    {
        Console.Clear();
        RenderGrid();
        RenderBackground(0, 0, 60, 15);
        RenderStructures();
        DrawExitArea(27, 15, 26, 15);
        //RenderPlayer(29, 7);
        //Input.ToggleCharacter(RenderPlayer(29, 7));
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        DrawThisAtXY("", 0, 16);
    }

    public static void RenderPlayer(int playerx, int playery) //player drawing (int playerx, int playery)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        DrawThisAtXY("▒▒", _lastPlayerCoords.x, _lastPlayerCoords.y); //▒
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        DrawThisAtXY("-Q¤", playerx, playery); //DrawThisAtXY("-Q¤", playerx, playery);
        Console.ResetColor();
        _lastPlayerCoords.x = playerx;
        _lastPlayerCoords.y = playery;
    }

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


    /*
    //prototype
    private static void DrawNorthEastMountainBig(string bannerSign, int mtStartingX, int mtStartingY, int mtEndingX,
        int mtEndingY)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        for (int h = mtStartingY; h < mtStartingY + 6; h + mtEndingY; h++)
        {
            for (int d = mtStartingX + 1; d < mtStartingX + mtEndingX; d++)
            {
                DrawThisAtXY("▒", d, h); //▒
            }
        }

        Console.ResetColor();


        //Topp of mountain
        Console.ForegroundColor = ConsoleColor.DarkGray;
        for (int i = mtStartingY; i < mtStartingY + 1; i++) //höjden taket printas på
        {
            DrawThisAtXY(@"█", mtStartingX, i); //(@"███████████",
        }

        //banner
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.White;
        DrawThisAtXY(bannerSign, mtStartingX + 1, mtStartingY + 2); //djup in från vänster där banner startar

        Console.ResetColor();
        //vänster vägg av hus
        Console.ForegroundColor = ConsoleColor.DarkGray;
        for (int i = mtStartingY + 1; i < mtStartingY + 4; i++)
        {
            DrawThisAtXY("█", mtStartingX, i);
        }

        //Filler på tredje rad
        DrawThisAtXY("█████████", mtStartingX + 1, mtStartingY + 1);
        //höger vägg av hus
        for (int i = mtStartingY + 1; i < mtStartingY + 4; i++)
        {
            DrawThisAtXY("█", mtStartingX + 10, i);
        }

        //Vägg bakom dörr
        Console.ForegroundColor = ConsoleColor.DarkGray;
        DrawThisAtXY("█████████", mtStartingX + 1, mtStartingY + 3);
        //Dörrprint
        Console.ForegroundColor = ConsoleColor.Black;
        DrawThisAtXY("██", mtStartingX + 4, mtStartingY + 3);
    }
    */

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


/*
▂▃▅▇█▓▒░۩۞۩        ۩۞۩░▒▓█▇▅▃▂
♚ ♛ ♜ ♝ ♞ ♟ ♔ ♕ ♖ ♗ ♘ ♙
*/