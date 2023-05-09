using ShaRPG.View.GUI;
using ShaRPGame.Controllers;
using ShaRPGame.Controllers.DebugMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.View.DebugMenu
{
    internal class ItemGeneratorView
    {
        public static void Menu()
        {
            MenuOptions();
            string input = Gui.GetInputIntUpperCase("Select one option.");
            ItemGeneratorController.ProcessInput(input);
        }

        private static void MenuOptions()
        {
            Gui.MenuTitle("=== Item Generator ===");
            Gui.MenuTitle("Press one of the options so you can generate an item.");
            Gui.MenuOption(0, "Generate a random (L)ight Armor");
            Gui.MenuOption(-1, "(E)xit to Main Menu");
        }
    }
}
