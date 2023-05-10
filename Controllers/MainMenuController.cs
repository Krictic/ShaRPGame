using ShaRPGame.View;

namespace ShaRPGame.Controllers
{
    internal class MainMenuController
    {
        public MainMenuController() { }

        public static void ProcessInput(string input)
        {
            switch (input)
            {
                case "-1":
                case "E":
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case "-2":
                case "D":
                    Console.Clear();
                    DebugMenuView.Menu();
                    break;
                case "1":
                case "N":
                    Console.Clear();
                    NewGameView.Menu();
                    break;
                case "2":
                case "l":
                    Console.Clear();
                    LoadGameView.Menu();
                    break;
                case "3":
                case "S":
                    Console.Clear();
                    SaveGameView.Menu();
                    break;
                case "4":
                case "C":
                    Console.Clear();
                    CharacterCreatorView.Menu();
                    break;
                case "5":
                case "V":
                    Console.Clear();
                    CharacterSelectorView.Menu();
                    break;
                case "6":
                case "O":
                    Console.Clear();
                    OptionsView.Menu();
                    break;
                default:
                    Console.Clear();
                    MainMenuView.Menu();
                    break;
            }
        }
    }
}
