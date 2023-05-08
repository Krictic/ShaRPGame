using ShaRPGame.Model.Entities.Models.PlayerCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.InstanceModels
{
    internal sealed class ActiveCharacterModel
    {
        private CharacterModel activeCharacter;
        private static ActiveCharacterModel _instance;

        public CharacterModel GetActiveCharacter()
        {
            return activeCharacter;
        }

        public void SetActiveCharacter(CharacterModel? value)
        {
            activeCharacter = value;
            Console.WriteLine(activeCharacter.GetName());
        }

        public static ActiveCharacterModel GetIntance()
        {
            if (_instance == null)
            {
                _instance = new ActiveCharacterModel();
            }
            return _instance;
        }

        public static void ClearInstance()
        {
            _instance = null;
        }
    }
}
