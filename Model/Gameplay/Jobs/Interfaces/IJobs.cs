using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.Gameplay.Jobs.Interfaces
{
    internal interface IJobs
    {
        // The plan here is to implement a system of jobs which will
        // give some stats obonuses defining diferent jobs.
        string GetjobName();
        void SetjobName(string value);

        // Calculates the job stat bonuses
        public void bonusesCalc();


    }
}
