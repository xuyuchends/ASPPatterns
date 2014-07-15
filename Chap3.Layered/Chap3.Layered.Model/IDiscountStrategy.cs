using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Model
{
    //打折策略
   public  interface IDiscountStrategy
    {
       decimal ApplyExtraDiscontsTo(decimal OriginalSalesPrice);
    }
}
