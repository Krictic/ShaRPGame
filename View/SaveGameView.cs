using ShaRPG.View.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.View
{
    internal class SaveGameView
    {
        public static void Menu()
        {
            MenuOptions();
        }

        public static void MenuOptions()
        {
            Gui.MenuTitle("Welcome to Save Game!");
        }
    }
}
