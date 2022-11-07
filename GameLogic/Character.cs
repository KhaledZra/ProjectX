namespace GameLogic;
class Character : Entity
{
    public string GoodGuy { get; set; }

    public Character(string name, int id, int health, int level) : base(name, id, health, level)
    {

    }

    // public static void ChooseCharcter()
    // {

    //     ConsoleKey x = Console.ReadKey().Key;

    //     if(x == ConsoleKey.D1)
    //     {
    //     List<Character> myCharacter = GetAllCharacters();

    //     foreach (Character currentCharacter in myCharacter)
    //     {
            
    //     }

    //     }

    // }

    // public static List<Character> GetAllCharacters()
    // {
    //     return new List<Character>()
    //     {
    //     new("Omar", 1, 0, 1),    
    //     new("Khaled", 2, 0, 1),    
    //     new("Robert", 3, 0, 1)
    //     };

    // }

}