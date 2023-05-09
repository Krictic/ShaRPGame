using ShaRPG.View.GUI;
using ShaRPGame.Model;
using ShaRPGame.Model.Entities.Models.PlayerCharacters;
using ShaRPGame.Model.InstanceModels;
using ShaRPGame.View;

namespace ShaRPGame.Controllers
{
    internal class CharacterSelectorController
    {
        // Todo: make
        public static void ListProcessing()
        {
            int input = 0;
            CharacterListModel CharaList = CharacterSelectorModel.ListAll();
            Console.WriteLine("Please, select the index of the character you wish to select to activate it.");
            
            try
            {
                input = Convert.ToInt32(Gui.GetInputIntBasic(input).Trim());
                CharacterModel character = CharaList.GetCharacterList()[input];
                CharacterSelectorModel.ActivateCharacter(character);
                ActiveCharacterModel activeCharacterInstance = ActiveCharacterModel.GetIntance();
                CharacterModel activeCharacter = activeCharacterInstance.GetActiveCharacter();
                Gui.PrintLine(activeCharacter.GetName() + " has been activated.");
                MainMenuView.Menu();
            }
            catch (Exception ex)
            {
                Gui.Alert(ex.Message);
                ListProcessing();
            }
            
        }
    }
}
