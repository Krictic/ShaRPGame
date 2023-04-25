using ShaRPG.View.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.View
{
    internal class CharacterSelectorView
    {
        public static void Menu()
        {
            MenuOptions();
        }

        public static void MenuOptions()
        {
            Gui.MenuTitle("Welcome to Character Selector!");
        }
    }
}
