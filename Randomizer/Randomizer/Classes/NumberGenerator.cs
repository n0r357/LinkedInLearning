using Randomizer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Classes
{
    internal class NumberGenerator : IRandomizer
    {
        public double GetRandomNumber(double inputUpperBoundNumber)
        {
            Random random = new Random();
            double seed = random.NextDouble();
            return seed * inputUpperBoundNumber;
        }
    }
}
