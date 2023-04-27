using ShaRPG.View.GUI;
using ShaRPGame.Controllers;
using ShaRPGame.Model.Entities.PlayerCharacters;
using ShaRPGame.Model.InstanceModels;

namespace ShaRPGame.View
{
    internal class MainMenuView
    {
        public static void Menu()
        {
            MenuOptions();
            string input = Gui.GetInputIntUpperCase("Select one option.");
            MainMenuController.ProcessInput(input);
        }

        private static void MenuOptions()
        {
            Console.Clear();
            CharacterModel activeCharacter = ActiveCharacterModel.GetIntance().GetActiveCharacter();
            if (activeCharacter != null)
            {
                //Gui.PrintLine($"Active Character: {activeCharacter.GetName()} | Job: {activeCharacter.GetJobClass()}");
                Gui.CharacterBannerCreate(activeCharacter);
            }
            Gui.MenuTitle("Welcome to ShaRPGame!");
            Gui.MenuOption(1, "(N)ew game");
            Gui.MenuOption(2, "(L)oad Game");
            Gui.MenuOption(3, "(S)ave Game");
            Gui.MenuOption(4, "(C)haracter Creator");
            Gui.MenuOption(5, "(V)iew and Select Characters");
            Gui.MenuOption(6, "(O)ptions");
            Gui.MenuOption(-1, "(E)xit");
            Gui.MenuOption(-2, "(D)ebug Mode");
        }
    }
}
