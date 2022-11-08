namespace UserInterface;

public class Input
{
    private Dictionary<string, ConsoleKey> _movementInputDict;

    public Input()
    {
        _movementInputDict = SetMovementInput();
    }

    private Dictionary<string, ConsoleKey> SetMovementInput()
    {
        Dictionary<string, ConsoleKey> tempDict = new();
        tempDict.Add("ArrowUp", ConsoleKey.UpArrow);
        tempDict.Add("ArrowDown", ConsoleKey.DownArrow);
        tempDict.Add("ArrowLeft", ConsoleKey.LeftArrow);
        tempDict.Add("ArrowRight", ConsoleKey.RightArrow);
        return tempDict;
    }

    public void CheckIfMovementInput(ConsoleKey consoleKey) // vi hittar
    {
        foreach (var item in _movementInputDict)
        {
            if (item.Value == consoleKey)
            {
               HandleMovementInput(consoleKey);
            }
        }
    }

    public void HandleMovementInput(ConsoleKey movementKey) // vi hanterar om vi hittar knappen
    {
        switch (movementKey)
        {
            case ConsoleKey.UpArrow:
                //MovementLogicHandler();
                break;
            case ConsoleKey.DownArrow:
                //MovementLogicHandler();
                break;
            case ConsoleKey.LeftArrow:
                //MovementLogicHandler();
                break;
            case ConsoleKey.RightArrow:
                //MovementLogicHandler();
                break;
        }
    }
}