using ShaRPG.View.GUI;
using ShaRPGame.Model;
using ShaRPGame.Model.Entities.PlayerCharacters;
using ShaRPGame.Model.InstanceModels;
using ShaRPGame.View;

namespace ShaRPGame.Controllers
{
    internal class CharacterCreationControl
    {
        public static void ProcessInput(string input)
        {
            switch (input)
            {
                case "-1":
                case "R":
                    Console.Clear();
                    MainMenuView.Menu();
                    break;
                case "1":
                case "C":
                    Console.Clear();
                    CharacterCreatorModel.CreateCharacter();
                    CharacterCreatorView.Menu();
                    break;
                default:
                    Console.Clear();
                    Gui.Alert("Invalid input, pleae try again.");
                    CharacterCreatorView.Menu();
                    break;
            }
        }
    }
}
