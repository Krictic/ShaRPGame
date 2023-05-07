using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.Entities.EntityInterfaces
{
    internal interface IPlayer
    {
        public bool GetIsReincarnated();
        public void SetIsReincarnated(bool value);
        public int GetDeathCount();
        public void SetDeathCount(int value);
        public int GetReputation();
        public void SetReputation(int value);

        
    }
}
