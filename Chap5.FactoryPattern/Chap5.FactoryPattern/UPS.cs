using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.FactoryPattern
{
    public class UPS : IShippingCourier
    {
        public string GenerateConsignmentLaberFor(Address address)
        {
            return "UPS-XXXX-XXXX-XXXX";
        }
    }
}
