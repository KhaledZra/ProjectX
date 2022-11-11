namespace UserInterface;

public enum GameState
{
    MainMenu,

    RoamingMap,
    CharacterHandler,
    SetCharacterClass,
    SetCharacterName,
    ShopMenu,
    BuyFromShop,
    SellInShop,
    TutorialMenu,
    FightingMenu,
    WonMenu,
    LostMenu,
    LoadCharacter, // Lägg character till DB
    QuitGame
}