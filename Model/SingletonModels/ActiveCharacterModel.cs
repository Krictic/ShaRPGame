using ShaRPGame.Model.Entities.PlayerCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.InstanceModels
{
    internal sealed class ActiveCharacterModel
    {
        private Character? activeCharacter;
        private static ActiveCharacterModel _instance;

        public Character? GetActiveCharacter()
        {
            return activeCharacter;
        }

        public void SetActiveCharacter(Character? value)
        {
            activeCharacter = value;
        }

        public static ActiveCharacterModel GetIntance()
        {
            if (_instance == null)
            {
                _instance = new ActiveCharacterModel();
            }
            return _instance;
        }
    }
}
