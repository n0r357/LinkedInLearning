using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingDelegate
{
    internal class ShippingZone1 : ShippingDestination
    {
        public ShippingZone1()
        {
            this.isHishRisk = false;
        }
        public override void CalculateShippingFee(decimal inputPrice, ref decimal outputFee)
        {
            outputFee = inputPrice * 0.25m;
        }
    }
    internal class ShippingZone2 : ShippingDestination
    {
        public ShippingZone2()
        {
            this.isHishRisk = true;
        }
        public override void CalculateShippingFee(decimal inputPrice, ref decimal outputFee)
        {
            outputFee = inputPrice * 0.12m;
        }
    }
    internal class ShippingZone3 : ShippingDestination
    {
        public ShippingZone3()
        {
            this.isHishRisk = false;
        }
        public override void CalculateShippingFee(decimal inputPrice, ref decimal outputFee)
        {
            outputFee = inputPrice * 0.08m;
        }
    }
    internal class ShippingZone4 : ShippingDestination
    {
        public ShippingZone4()
        {
            this.isHishRisk = true;
        }
        public override void CalculateShippingFee(decimal inputPrice, ref decimal outputFee)
        {
            outputFee = inputPrice * 0.04m;
        }
    }
    internal class ShippingZone5 : ShippingDestination
    {
        public ShippingZone5()
        {
            this.isHishRisk = false;
        }
        public override void CalculateShippingFee(decimal inputPrice, ref decimal outputFee)
        {
            outputFee = inputPrice * 0.15m;
        }
    }
}
