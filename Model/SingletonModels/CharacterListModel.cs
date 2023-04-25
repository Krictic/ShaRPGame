using ShaRPGame.Model.Entities.PlayerCharacters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.InstanceModels
{
    internal sealed class CharacterListModel
    {

        public CharacterListModel()
        {
            ArrayList CharList = new ArrayList();
            SetCharacterList(CharList);
        }

        private ArrayList CharacterList { get; set; }
        private static CharacterListModel _instance { get; set; }

        public ArrayList GetCharacterList()
        {
            return CharacterList;
        }

        public void SetCharacterList(ArrayList value)
        {
            CharacterList = value;
        }

        public void AddToCharList(CharacterListModel character)
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
