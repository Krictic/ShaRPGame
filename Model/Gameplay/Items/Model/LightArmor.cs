using ShaRPG.View.GUI;
using ShaRPGame.Model.Entities.Models.PlayerCharacters;
using ShaRPGame.Model.Gameplay.Items.Interfaces;
using ShaRPGame.Model.GameplayModels.Items.ItemInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.Gameplay.Items.Model
{
    internal class LightArmor : IItem, IEquipment, IArmor
    {
        private string ItemName = "Placeholder Name";
        private string ItemDescription = "Placeholder Descriptions";
        private string ItemType = "Placeholder Type";
        private int ItemValue;
        private double Itemweight;
        private int ItemRarity;
        private int Durability;
        private double Resist;
        private double Block;

        public string GetItemName()
        {
            return this.ItemName;
        }

        public void SetItemName(string value)
        {
            this.ItemName = value;
        }

        public string GetItemDescription()
        {
            return this.ItemDescription;
        }

        public void SetItemDescription(string value)
        {
            this.ItemDescription = value;
        }

        public string GetItemType()
        {
            return this.ItemType;
        }

        public void SetItemType(string value)
        {
            this.ItemType = value;
        }

        public int GetItemValue()
        {
            return this.ItemValue;
        }

        public void SetItemValue(int value)
        {
            this.ItemValue = value;
        }

        public double GetItemWeight()
        {
            return this.Itemweight;
        }

        public void SetItemWeight(double value)
        {
            this.Itemweight = value;
        }

        public int GetItemRarity()
        {
            return this.ItemRarity;
        }

        public void SetItemRarity(int value)
        {
            this.ItemRarity = value;
        }

        public double Getblock()
        {
            return this.Block;
        }

        public double GetResist()
        {
            return this.Resist;
        }

        public void Setblock(double value)
        {
            this.Block = value;
        }

        public void SetResist(double value)
        {
            this.Resist = value;
        }

        public int Getdurability()
        {
            return this.Durability;
        }

        public void Setdurability(int value)
        {
            this.Durability = value;
        }

        public void GenerateRandom(double resist, double block)
        {
            Random rng = new Random();

            SetResist(rng.NextDouble() * resist);
            Setblock(rng.NextDouble() * block);
            Displaystats();
        }

        public void Displaystats()
        {
            string block = String.Format("{0:0.00}", this.Block);
            string resist = String.Format("{0:0.00}", this.Resist);
            Gui.PrintLine($"Name: {this.ItemName}\n" +
                          $"Item Description: {this.ItemDescription}\n" +
                          $"Type: {this.ItemType}\n"+
                          $"Block: {block}\n" +
                          $"Resist: {resist}");
        }

        // This will be rather ocmplex to implement, but this should give the user some stat bonuses like in DIablo
        public int StatBonus(CharacterModel character)
        {
            throw new NotImplementedException();
        }
    }
}
