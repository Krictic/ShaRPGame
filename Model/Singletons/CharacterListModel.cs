using ShaRPGame.Model.Entities.Models.PlayerCharacters;
using System.Collections;

namespace ShaRPGame.Model.InstanceModels
{
    internal sealed class CharacterListModel
    {

        public CharacterListModel()
        {
            InitCharacterList();
        }

        public List<CharacterModel> CharacterList { get; set; }
        private static CharacterListModel _instance { get; set; }

        public List<CharacterModel> GetCharacterList()
        {
            return CharacterList;
        }

        public void InitCharacterList()
        {
            CharacterList = new List<CharacterModel>();
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

        public  int GetLength() 
        {
            if (_instance != null) 
            {
                int count = CharacterList.Count;
                return count;
            }

            else
            {
                return 0;
            }
        }
    }
}
