namespace UserInterface;

public class GameStateHandler
{

    public static void SwitchMenu()
    {
        char ch = Convert.ToChar(Console.ReadLine());

        switch (ch)
        {
            case '1':

                DrawMenu.MainMenu();
                DrawMenu.CharacterMenu();
                DrawMenu.CharacterName();
                DrawMenu.ChooseCharacterClass();
                break;

            case '2':

                //DrawRoaming();
                break;

            case '3':

                //ShopMenu();    
                break;

            case '4':

                //TutorialMenu();
                break;
        }
    }
}