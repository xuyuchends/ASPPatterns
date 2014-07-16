using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Model
{
    /// <summary>
    /// 工厂模式
    /// </summary>
   public static class DiscountFactory
    {
       public static IDiscountStrategy GetDiscountStrategyFor(CustomerType customerType)
       {
           switch (customerType)
           {
               case CustomerType.Standred:
                   return new TradeDiscountStrategy();
               default :
                   return new NullDiscountStrategy();
           }
       }
    }
}
