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

        public LightArmor()
        {
            SetItemName("Placeholder Name");
            SetItemDescription("Placeholder Descriptions");
            SetItemType("Placeholder Type");
            Setdurability(100);
        }

        private string ItemName;
        private string ItemDescription;
        private string ItemType;
        private double ItemValue;
        private double ItemWeight;
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

        public double GetItemValue()
        {
            return this.ItemValue;
        }

        public void SetItemValue(double value)
        {
            this.ItemValue = value;
        }

        public double GetItemWeight()
        {
            return this.ItemWeight;
        }

        public void SetItemWeight(double value)
        {
            this.ItemWeight = value;
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

        public void GenerateRandom(double resist, double block, double itemValue, double itemWeight, int rarity)
        {
            Random rng = new Random();

            SetResist(rng.NextDouble() * resist);
            Setblock(rng.NextDouble() * block);
            SetItemValue(rng.NextDouble() * itemValue);
            SetItemWeight(rng.NextDouble() * itemWeight);
            SetItemRarity(rng.Next(1,10) * rarity);
            Displaystats();
        }

        public void Displaystats()
        {
            string block = String.Format("{0:0.00}", this.Block);
            string resist = String.Format("{0:0.00}", this.Resist);
            string value = String.Format("{0:0.00}", this.ItemValue);
            string weight = String.Format("{0:0.00}", this.ItemWeight);
            Gui.PrintLine($"Name: {this.ItemName}\n" +
                          $"Item Description: {this.ItemDescription}\n" +
                          $"Type: {this.ItemType}\n"+
                          $"Durability: {this.Durability}\n"+
                          $"Rarirty: {this.ItemRarity}\n"+
                          $"Value: {value} gold\n"+
                          $"Weight: {weight}kg\n"+
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
