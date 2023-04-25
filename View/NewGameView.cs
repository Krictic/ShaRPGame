using ShaRPG.View.GUI;
using ShaRPGame.Controllers;
using ShaRPGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.View
{
    internal class NewGameView
    {
        public static void Menu()
        {
            MenuOptions();
        }

        public static void MenuOptions()
        {
            Gui.MenuTitle("Welcome to New Game!");
            Gui.MenuOption(1, "(B)asic Stats");
            Gui.MenuOption(2, "(D)etailed Stats");
            Gui.MenuOption(3, "(A)pply Stat Points");
            Gui.MenuOption(5, "(Q)uest Selector");
            Gui.MenuOption(6, "(S)art Quest");
            Gui.MenuOption(-1, "(E)xit");
        }
    }
}
