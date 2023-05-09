using ShaRPG.View.GUI;
using ShaRPGame.Model;
using ShaRPGame.Model.Entities.Models.PlayerCharacters;
using ShaRPGame.Model.InstanceModels;
using ShaRPGame.View;

namespace ShaRPGame.Controllers
{
    internal class CharacterSelectorController
    {
        // This method does too much, I should look into it later
        public static void ListProcessing()
        {
            bool validInput = false;
            int input = 0;
            CharacterListModel CharaList = CharacterSelectorModel.ListAll();
            Console.WriteLine("Please, select the index of the character you wish to select to activate it.");
            while (!validInput) // This ensures the method will keep running so long a invalid input is given.
            {
                try
                {
                    input = Convert.ToInt32(Gui.GetInputIntBasic(input));
                    CharacterModel character = CharaList.GetCharacterList()[input]; // This is not a copy but an assignment.
                    CharacterSelectorModel.ActivateCharacter(character); 
                    ActiveCharacterModel activeCharacterInstance = ActiveCharacterModel.GetIntance();
                    CharacterModel activeCharacter = activeCharacterInstance.GetActiveCharacter();
                    Gui.PrintLine(activeCharacter.GetName() + " has been activated.");
                    MainMenuView.Menu();
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Gui.Alert(ex.Message);
                }
            }
        }
    }
}
