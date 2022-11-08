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

    public ConsoleKey CheckIfMovementInput(ConsoleKey consoleKey) // vi hittar
    {
        foreach (var item in _movementInputDict)
        {
            if (item.Value == consoleKey)
            {
                return consoleKey;
            }
        }

        return ConsoleKey.Z;
    }
}