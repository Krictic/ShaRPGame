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
            bool isValidInput = false;
            while (isValidInput == false)
            {
                switch (input)
                {
                    case "-1":
                    case "M":
                        Console.Clear();
                        MainMenuView.Menu();
                        isValidInput = true;
                        break;
                    case "1":
                    case "C":
                        Console.Clear();
                        isValidInput = true;
                        CharacterCreatorModel.CreateCharacter();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
