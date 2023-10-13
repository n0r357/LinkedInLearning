using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesShipping.Classes
{
    public delegate void ShippingFeeDelegate(decimal itemPrice, ref decimal fee);
    abstract class ShippingCalculator
    {
        public bool isHighRisk;
        public virtual void calculateShippingFee(decimal itemPrice, ref decimal fee)
        {

        }
    }
}
