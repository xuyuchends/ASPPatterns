using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.FactoryPattern
{
    /// <summary>
    /// 货运公司接口
    /// </summary>
   public  interface IShippingCourier
    {
       string GenerateConsignmentLaberFor(Address address);
    }
}
