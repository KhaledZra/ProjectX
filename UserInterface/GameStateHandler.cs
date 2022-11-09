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

                    MenuOutput.MainMenu();
                    MenuOutput.CharacterMenu();
                    MenuOutput.CharacterName();
                    MenuOutput.ChooseCharacterClass();
                    break;

                case '2':

                    //DrawRoaming();
                    break;

                case '3':

                    MenuOutput.ShopMenu();
                    break;

                case '4':

                    MenuOutput.TutorialMenu();
                    break;

                case '5':

                    MenuOutput.FightingMenu();
                    break;

                case '6':

                    MenuOutput.WonMenu();
                    break;

                case '7':

                    MenuOutput.LooseMenu();
                    break;
            }
        }
    }
}