using ShaRPG.View.GUI;
using ShaRPGame.Model.Entities.Models.PlayerCharacters;
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
        public static void CreateCharacter(string name, string description, string jobClass, int age)
        {
            CharacterModel character = new CharacterModel(name, description, jobClass, age);
            character.CalculateStats(1);
            Console.WriteLine($"The character {character.GetName()} has been created!");
            CharacterListModel charList = CharacterListModel.GetIntance();
            charList.AddToCharList(character);
            character.ToStringComplete();
            //foreach (CharacterModel item in charList.GetCharacterList())
            //{
            //    Console.WriteLine(item.GetName());
            //}
        }

    }
}
