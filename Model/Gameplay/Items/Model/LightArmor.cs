using ShaRPG.View.GUI;
using ShaRPGame.Model.Gameplay.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.Gameplay.Items.Model
{
    internal class LightArmor : IArmor
    {
        private double Resist;
        private double Block;

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

        public void GenerateRandom(double resist, double block)
        {
            Random rng = new Random();
            double ResistOutput = rng.NextDouble() * resist;
            double BlockOutput = rng.NextDouble() * block;

            SetResist(ResistOutput);
            Setblock(BlockOutput);
            Displaystats();
        }

        public void Displaystats()
        {
            Gui.PrintLine($"Block: {this.Block}\n" +
                          $"Resist: {this.Resist}");
        }
    }
}
