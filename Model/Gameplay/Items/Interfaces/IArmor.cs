using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.Gameplay.Items.Interfaces
{
    internal interface IArmor
    {
        double GetResist();
        void SetResist(double value);
        double Getblock();
        void Setblock(double value);
    }
}
