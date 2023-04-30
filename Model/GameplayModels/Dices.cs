using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.GameplayModels
{
    internal class Dices
    {
        // Will "roll" a n-sided dice
        public static int RollDice(int size)
        {
            Random rng = new Random();
            return rng.Next(size + 1);
        }
    }
}
