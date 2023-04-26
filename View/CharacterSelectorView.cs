using ShaRPG.View.GUI;
using ShaRPGame.Controllers;
using ShaRPGame.Model;
using ShaRPGame.Model.Entities.PlayerCharacters;
using ShaRPGame.Model.InstanceModels;
using System.Collections;

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
