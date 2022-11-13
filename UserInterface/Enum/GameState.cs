namespace UserInterface;

public enum GameState
{
    MainMenu,
    RoamingMap,
    CharacterHandler,
    LoadCharacter, // Ladda character från DB
    SetCharacterVocation,
    SetCharacterName,
    ShopMenu,
    BuyFromShop,
    SellInShop,
    TutorialMenu,
    FightMenu,
    Fighting,
    WonMenu,
    LostMenu,
    QuitGame,
    ExitProgram
}