using ShaRPGame.Model.Entities.PlayerCharacters;
using ShaRPGame.Model.InstanceModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model
{
    internal class CharacterCreatorModel
    {
        public CharacterCreatorModel()
        {
        }

        public static CharacterModel GetNewCharacter()
        {
            return new CharacterModel();
        }
        public static void CreateCharacter()
        {
            Console.WriteLine("Creating a new character.");
            CharacterModel character = CharacterCreatorModel.GetNewCharacter();
            CharacterListModel charList = CharacterListModel.GetIntance();
            charList.GetCharacterList().Add(character);
            Console.WriteLine($"The character {character.GetName()} has been created!");
        }

    }
}
