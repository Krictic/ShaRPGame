using ShaRPG.View.GUI;
using ShaRPGame.Controllers;

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
            
            CharacterSelectorController.ListProcessing();

        }
    }
}
