using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.Gameplay.Items.Interfaces
{
    internal interface IEquipment
    {
        int Getdurability();
        void Setdurability(int value);
        int GetRarity();
        void SetRarity(int value);
    }
}
