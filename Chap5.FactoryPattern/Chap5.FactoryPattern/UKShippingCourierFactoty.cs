using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.FactoryPattern
{
    public static class UKShippingCourierFactoty
    {
        public static IShippingCourier CreateShippingCourier(Order order)
        {
            if ((order.TotalCost > 100) || (order.WeightInKG > 5))
            {
                return new DHL();
            }
            else
            {
                return new UPS();
            }
        }
    }
}
