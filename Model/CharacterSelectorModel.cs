using ShaRPG.View.GUI;
using ShaRPGame.Model.Entities.PlayerCharacters;
using ShaRPGame.Model.InstanceModels;
using System.Collections;

namespace ShaRPGame.Model
{
    internal class CharacterSelectorModel
    {
        CharacterSelectorModel()
        {

        }

        public static void ActivateCharacter(CharacterModel character)
        {
            ActiveCharacterModel activeCharacter =  ActiveCharacterModel.GetIntance();
            activeCharacter.SetActiveCharacter(character);
        }

        public static CharacterListModel ListAll()
        {
            CharacterListModel charList = CharacterListModel.GetIntance();
            int i = 0;

            foreach (CharacterModel item in charList.GetCharacterList())
            {
                Gui.MenuOption(i, item.GetName());
                i++;
            }

            return charList;
        }
    }
}
