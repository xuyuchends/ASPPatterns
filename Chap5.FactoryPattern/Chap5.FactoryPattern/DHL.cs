using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.FactoryPattern
{
    public class DHL : IShippingCourier
    {
        public string GenerateConsignmentLaberFor(Address address)
        {
            return "DHL-XXXX-XXXX-XXXX";
        }
    }
}
