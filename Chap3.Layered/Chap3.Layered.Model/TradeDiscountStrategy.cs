using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Model
{
    /// <summary>
    /// 95折
    /// </summary>
   public  class TradeDiscountStrategy:IDiscountStrategy
    {
       public decimal ApplyExtraDiscontsTo(decimal OriginalSalesPrice)
       {
           return OriginalSalesPrice * 0.95M;
       }
    }
}
