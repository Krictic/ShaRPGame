using ShaRPG.View.GUI;
using ShaRPGame.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.View
{
    internal class DebugMenuView
    {
        public static void Menu()
        {
            MenuOptions();
            string input = Gui.GetInputIntUpperCase("Select one option.");
            DebugMenuController.ProcessInput(input);
        }

        private static void MenuOptions()
        {
            Gui.MenuTitle("=== Debug Menu ===");
            Gui.Alert("This could break something so be warned or help me God.");
            Gui.MenuOption(0, "(G)enerate a random item");
            Gui.MenuOption(-1, "(E)xit to Main Menu");
        }
    }
}
