using ShaRPG.View.GUI;
using ShaRPGame.Controllers;

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
            Gui.MenuTitle("Welcome to the Character Creator!");
            Gui.MenuOption(1, "(C)reate a New Character");
            Gui.MenuOption(2, "(E)dit a Character");
            Gui.MenuOption(3, "(D)elete Character");
            Gui.MenuOption(4, "(V)iew Characters");
            Gui.MenuOption(-1, "(R)eturn to Main Menu");
        }
    }
}
