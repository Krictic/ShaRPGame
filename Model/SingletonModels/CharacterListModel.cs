using ShaRPGame.Model.Entities.PlayerCharacters;
using System.Collections;

namespace ShaRPGame.Model.InstanceModels
{
    internal sealed class CharacterListModel
    {

        public CharacterListModel()
        {
            InitCharacterList();
        }

        public ArrayList CharacterList { get; set; }
        private static CharacterListModel _instance { get; set; }

        public ArrayList GetCharacterList()
        {
            return CharacterList;
        }

        public void InitCharacterList()
        {
            CharacterList = new ArrayList();
        }

        public void AddToCharList(CharacterModel character)
        {
            GetCharacterList().Add(character);
        }

        public static CharacterListModel GetIntance()
        {
            if (_instance == null)
            {
                _instance = new CharacterListModel();
            }
            return _instance;
        }
    }
}
