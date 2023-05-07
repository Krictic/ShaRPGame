using ShaRPGame.Model.Entities.PlayerCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.GameplayModels.Items.ItemInterfaces
{
    internal interface IItem
    {

        string ItemName { get; set; }
        string ItemType { get; set; }
        int ItemValue { get; set; }
        double ItemWeight { get; set; }
        double ItemRarity { get; set; }

        public int StatBonus(CharacterModel character);
    }
}
