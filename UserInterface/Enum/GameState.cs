namespace UserInterface;

public enum GameState
{
    MainMenu,
    RoamingMap,
    CharacterHandler,
    LoadCharacter, // Ladda character från DB
    SetCharacterVocation,
    SetCharacterName,
    Mountain,
    ShopMenu,
    BuyFromShop,
    SellToShop,
    TutorialMenu,
    FightMenu,
    Fighting,
    WonMenu,
    LostMenu,
    QuitGame,
    ExitProgram
}