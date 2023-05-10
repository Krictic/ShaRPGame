using ShaRPG.View.GUI;
using ShaRPGame.Controllers.DebugMenu;

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
