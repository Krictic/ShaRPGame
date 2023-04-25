using ShaRPGame.Model.Entities.PlayerCharacters;
using ShaRPGame.Model.InstanceModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model
{
    internal class CharacterCreatorModel
    {
        public CharacterCreatorModel()
        {
        }

        public static Character GetNewCharacter()
        {
            return new Character();
        }
        public static void CreateCharacter()
        {
            Console.WriteLine("Creating a new character.");
            Character character = CharacterCreatorModel.GetNewCharacter();
            character.speak();
            CharacterListModel charList = CharacterListModel.GetIntance();
            charList.GetCharacterList().Add(character);
            foreach (Character chara in charList.GetCharacterList())
            {
                Console.WriteLine(chara.speak());
            }
        }

    }
}
