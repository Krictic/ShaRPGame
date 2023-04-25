using ShaRPGame.Model.InstanceModels;

namespace ShaRPGame.Model
{
    internal class CharacterSelectorModel
    {
        CharacterSelectorModel()
        {

        }

        public void ActivateCharacter()
        {
            ActiveCharacterModel.GetIntance();
        }
    }
}
