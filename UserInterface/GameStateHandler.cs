namespace UserInterface;

public class GameStateHandler
{

    public static void SwitchMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("\n[1]MainMenu");
            Console.WriteLine("[2]DrawRoaming");
            Console.WriteLine("[3]ShopMenu");
            Console.WriteLine("[4]TutorialMenu");
            Console.WriteLine("[5]FightingMenu");
            Console.WriteLine("[6]WonMenu");
            Console.WriteLine("[7]WonMenu");

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

                    DrawMenu.ShopMenu();
                    break;

                case '4':

                    DrawMenu.TutorialMenu();
                    break;

                case '5':

                    DrawMenu.FightingMenu();
                    break;

                case '6':

                    DrawMenu.WonMenu();
                    break;

                case '7':

                    DrawMenu.LooseMenu();
                    break;
            }
        }
    }
}