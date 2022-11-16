namespace UserInterface;

public enum GameState
{
    MainMenu,
    RoamingMap,
    CharacterOptions,
    LoadCharacter, // Ladda character från DB
    PickVocation,
    PickName,
    InsideMountain,
    InsideShop,
    BrowsingStock,
    SellingToShop,
    InsideTutorial,
    FightMenu,
    Fighting,
    WonFight,
    LostFight,
    QuitGame,
    ExitProgram
}