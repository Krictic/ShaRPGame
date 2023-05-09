using ShaRPGame.Controllers.DebugMenu;
using ShaRPGame.View;
using ShaRPGame.View.DebugMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Controllers
{
    internal class DebugMenuController
    {
        public DebugMenuController() { }

        public static void ProcessInput(string input)
        {
            switch (input)
            {
                case "-1":
                case "E":
                    Console.Clear();
                    MainMenuView.Menu();
                    break;
                case "0":
                case "G":
                    Console.Clear();
                    ItemGeneratorView.Menu();
                    break;
                default:
                    Console.Clear();
                    MainMenuView.Menu();
                    break;
            }
        }
    }
}
