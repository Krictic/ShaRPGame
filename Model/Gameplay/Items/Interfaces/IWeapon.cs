using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.Gameplay.Items.Interfaces
{
    internal interface IWeapon
    {
        double GetBaseDamage();
        void SetBaseDamage(double value);

    }
}
