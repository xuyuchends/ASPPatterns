using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Model
{
    /// <summary>
    /// 不打折
    /// </summary>
   public  class NullDiscountStrategy:IDiscountStrategy
    {
       public decimal ApplyExtraDiscontsTo(decimal OriginalSalesPrice)
       {
           return OriginalSalesPrice;
       }
    }
}
