using ShaRPG.View.GUI;
using ShaRPGame.Model;
using ShaRPGame.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Controllers
{
    internal class MainMenuController
    {

        public MainMenuController() 
        {

        }

        public static void ProcessInput(string input)
        {
            bool isValidInput = false;
            while (isValidInput == false)
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
                        Gui.Alert("Not implemented yet!");
                        isValidInput = true;
                        break;
                    case "1":
                    case "N":
                        Console.Clear();
                        isValidInput = true;
                        NewGameView.Menu();
                        break;
                    case "2":
                    case "l":
                        Console.Clear();
                        isValidInput = true;
                        LoadGameView.Menu();
                        break;
                    case "3":
                    case "S":
                        Console.Clear();
                        isValidInput = true;
                        SaveGameView.Menu();
                        break;
                    case "4":
                    case "C":
                        Console.Clear();
                        isValidInput = true;
                        CharacterCreatorView.Menu();
                        break;
                    case "5":
                    case "V":
                        Console.Clear();
                        isValidInput = true;
                        CharacterSelectorView.Menu();
                        break;
                    case "6":
                    case "O":
                        Console.Clear();
                        isValidInput = true;
                        OptionsView.Menu();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
