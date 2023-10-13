using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingDelegate
{
    internal class Runtime
    {
        public void Start()
        {
            bool loop = true;
            decimal shippingFee = 0.0m;
            ShippingFeeDelegate shippingDelegate;
            ShippingDestination shippingDestination;

            while (loop)
            {
                switch (UI.MainMenu())
                {
                    case ConsoleKey.D1: //  Zone 1
                        shippingDestination = ShippingDestination.GetShippingZone(ConsoleKey.D1);
                        shippingDelegate = shippingDestination.CalculateShippingFee;
                        shippingDelegate(UI.AskForPrice(), ref shippingFee);
                        UI.AddPotetialHighRiskFee(shippingFee, shippingDestination.isHishRisk);
                        break;
                    case ConsoleKey.D2: //  Zone 2
                        shippingDestination = ShippingDestination.GetShippingZone(ConsoleKey.D2);
                        shippingDelegate = shippingDestination.CalculateShippingFee;
                        shippingDelegate(UI.AskForPrice(), ref shippingFee);
                        UI.AddPotetialHighRiskFee(shippingFee, shippingDestination.isHishRisk);
                        break;
                    case ConsoleKey.D3: //  Zone 3
                        shippingDestination = ShippingDestination.GetShippingZone(ConsoleKey.D3);
                        shippingDelegate = shippingDestination.CalculateShippingFee;
                        shippingDelegate(UI.AskForPrice(), ref shippingFee);
                        UI.AddPotetialHighRiskFee(shippingFee, shippingDestination.isHishRisk);
                        break;
                    case ConsoleKey.D4: //  Zone 4
                        shippingDestination = ShippingDestination.GetShippingZone(ConsoleKey.D4);
                        shippingDelegate = shippingDestination.CalculateShippingFee;
                        shippingDelegate(UI.AskForPrice(), ref shippingFee);
                        UI.AddPotetialHighRiskFee(shippingFee, shippingDestination.isHishRisk);
                        break;
                    case ConsoleKey.D5: //  Zone 5
                        shippingDestination = ShippingDestination.GetShippingZone(ConsoleKey.D5);
                        shippingDelegate = shippingDestination.CalculateShippingFee;
                        shippingDelegate(UI.AskForPrice(), ref shippingFee);
                        UI.AddPotetialHighRiskFee(shippingFee, shippingDestination.isHishRisk);
                        break;
                    case ConsoleKey.D6:
                        loop = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
