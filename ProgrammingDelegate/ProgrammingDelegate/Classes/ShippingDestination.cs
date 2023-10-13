using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingDelegate
{
    public delegate void ShippingFeeDelegate(decimal inputPrice, ref decimal outputFee);
    abstract class ShippingDestination
    {
        public bool isHishRisk;
        public virtual void CalculateShippingFee(decimal inputPrice, ref decimal outputFee) {}

        public static ShippingDestination GetShippingZone(ConsoleKey inputKey)
        {
            if (inputKey == ConsoleKey.D1)
            {
                return new ShippingZone1();
            }
            else if (inputKey == ConsoleKey.D2)
            {
                return new ShippingZone2();
            }
            else if (inputKey == ConsoleKey.D3)
            {
                return new ShippingZone3();
            }
            else if (inputKey == ConsoleKey.D4)
            {
                return new ShippingZone4();
            }
            else if (inputKey == ConsoleKey.D5)
            {
                return new ShippingZone5();
            }
            else
            {
                return null;
            }
        }
    }
}
