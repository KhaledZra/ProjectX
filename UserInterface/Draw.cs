using System.Diagnostics.Tracing;
using System.Xml;
using System.Text;

namespace UserInterface;
//run in high contrast theme preferably

public class Draw
{
    struct TwoOCoords //two coordinates flera variabler i en variabler, används ofta för koordinater
        //bättre såhär så man kan välja namnet ist för (int, int)
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    static void DrawThisAtXY(string text, int x, int y)
    {
        Console.SetCursorPosition(x, +y);
        Console.Write(text);
    }

    public static void RenderMap()
    {
        Console.Clear();
        Console.SetWindowPosition(0, 0);
        RenderGrid();
        Console.ResetColor();
        RenderBackground(0, 0);
        Console.ResetColor();
        Console.ResetColor();
        RenderHouses();
        Console.ResetColor();
        RenderPlayer(29, 7);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        DrawThisAtXY("", 0, 16);
    }

    private static void RenderGrid() //Grid size set
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
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
    }

    private static void RenderBackground(int bgStartx, int bgStarty)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 1);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 2);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 3);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 4);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 5);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 6);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 7);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 8);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 9);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 10);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 11);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 12);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 13);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = bgStartx + 1; i < bgStartx + 60; i++)
        {
            DrawThisAtXY("░", i, bgStarty + 14);
        }
        Console.ResetColor();
    }

    private static void RenderPlayer(int playerx, int playery) //player drawing
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        DrawThisAtXY("-Q¤", playerx, playery);
        Console.ResetColor();
    }


    private static void RenderHouses() // map houses @ x/y/ with bannertext
    {
        //startingx sätter djup, startingy sätter höjd
        DrawWestWingHouse(5, 2, "FightClub"); //starting-x = 2 in från cursor, starting-y = 2 ner från 2,0
        DrawEastWingHouse(45, 10, "  Shop   ");
        DrawWestWingHouse(5, 10, " Tutorial");
        DrawNorthEastMountain(45, 2, "Mount Adv.");
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
                i); //from kordinat x = 10 in från vänster och bara på kordinat y som ovan
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
}

//▂▃▅▇█▓▒░۩۞۩        ۩۞۩░▒▓█▇▅▃▂

//Det här är bara för att?
//public int y = 1;
//public string playerCharacter = "A";
//public string monsterCharacter = "¤"; //leta annat tecken i asci
//▂▃▅▇█▓▒░۩۞۩        ۩۞۩░▒▓█▇▅▃▂
//[̲̅$̲̅(̲̅ιοο̲̅)̲̅$̲̅]
//♚ ♛ ♜ ♝ ♞ ♟ ♔ ♕ ♖ ♗ ♘ ♙