using ShaRPG.View.GUI;
using ShaRPGame.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.View
{
    internal class CharacterCreatorView
    {
        public static void Menu()
        {
            MenuOptions();
            string input = Gui.GetInputIntUpperCase("");
            CharacterCreationControl.ProcessInput(input);
        }

        public static void MenuOptions()
        {
            Gui.MenuTitle("Welcome to CharacterModel Creator!");
            Gui.MenuOption(1, "(C)reate a New CharacterModel");
            Gui.MenuOption(2, "(E)dit a CharacterModel");
            Gui.MenuOption(3, "(D)elete CharacterModel");
            Gui.MenuOption(-1, "(R)eturn to Main Menu");
        }
    }
}
