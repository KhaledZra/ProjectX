namespace UserInterface;

public class Input
{
    public static ConsoleKeyInfo KeyPress { get; set; }

    /*
    public static void KeyActionHandler()
    {
        GetKeyInput();
    }

    public static void GetKeyInput()
    {
        ConsoleKeyInfo keyPress = Console.ReadKey();
        if (keyPress.Key == ConsoleKey.UpArrow || keyPress.Key == ConsoleKey.W)
        {
            MoveObjectUp();// nuvarande position ska in
        }
        else if (keyPress.Key == ConsoleKey.LeftArrow || keyPress.Key == ConsoleKey.A)
        {
            MoveObjectLeft();// nuvarande position ska in
        }
        else if (keyPress.Key == ConsoleKey.RightArrow || keyPress.Key == ConsoleKey.D)
        {
           MoveObjectRight();// nuvarande position ska in
        }
        else if
            (keyPress.Key == ConsoleKey.DownArrow || keyPress.Key == ConsoleKey.S)
        {
            MoveObjectDown();// nuvarande position ska in
        }
    }

    public static void MoveObjectUp(int currentX, int currentY)
    {
        Draw.RenderPlayer(1,1--).y--;
    }
    public static void MoveObjectLeft(int currentX, int currentY)
    {
        Draw.RenderPlayer.x--;
    }
    public static void MoveObjectRight(int currentX, int currentY)
    {
        Draw.RenderPlayer.x++;
    }
    public static void MoveObjectDown(int currentX, int currentY)
    {
        Draw.RenderPlayer.y++;
    }*/
}

/*public static void ToggleCharacter()
{
    Console.SetCursorPosition(29,7);
    ConsoleKeyInfo keyPress = Console.ReadKey();
    if (keyPress.Key == ConsoleKey.LeftArrow || keyPress.Key == ConsoleKey.A)
    {
        Draw.RenderPlayer.x--;
    }
    else if (keyPress.Key == ConsoleKey.RightArrow || keyPress.Key == ConsoleKey.D)
    {
        Draw.RenderPlayer.x++;
    }
    else if (keyPress.Key == ConsoleKey.UpArrow || keyPress.Key == ConsoleKey.W)
    {
        Draw.RenderPlayer.y--;
    }
    else if (keyPress.Key == ConsoleKey.DownArrow || keyPress.Key == ConsoleKey.S)
    {
        Draw.RenderPlayer.y++;
    }
}*/