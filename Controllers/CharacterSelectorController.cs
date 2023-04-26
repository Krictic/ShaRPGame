using ShaRPG.View.GUI;
using ShaRPGame.Model;
using ShaRPGame.Model.Entities.PlayerCharacters;
using ShaRPGame.Model.InstanceModels;
using ShaRPGame.View;

namespace ShaRPGame.Controllers
{
    internal class CharacterSelectorController
    {
        public static void ListProcessing()
        {
            CharacterListModel CharaList = CharacterSelectorModel.ListAll();
            int input = Convert.ToInt32(Gui.GetInputInt("Please, select the index of the character you wish to select to activate it."));
            CharacterModel character = (CharacterModel)CharaList.GetCharacterList()[input];
            CharacterSelectorModel.ActivateCharacter(character);
            ActiveCharacterModel activeCharacterInstance = ActiveCharacterModel.GetIntance();

            CharacterModel activeCharacter =  activeCharacterInstance.GetActiveCharacter();
            Gui.PrintLine(activeCharacter.GetName() + " has been activated.");
            MainMenuView.Menu();
        }
    }
}
