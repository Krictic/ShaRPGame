﻿using ShaRPGame.Model.Entities.Models.PlayerCharacters;

namespace ShaRPGame.Model.GameplayModels.Items.ItemInterfaces
{
    internal interface IItem
    {
        string GetItemName();
        void SetItemName(string value);

        string GetItemDescription();
        void SetItemDescription(string value);

        string GetItemType();
        void SetItemType(string value);

        double GetItemValue();
        void SetItemValue(double value);

        double GetItemWeight();
        void SetItemWeight(double value);

        int GetItemRarity();
        void SetItemRarity(int value);

        public int StatBonus(CharacterModel character);
    }
}
