using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.StrategyPattern
{
    /// <summary>
    /// 折扣策略
    /// </summary>
   public  class BacketDiscountPercentageOff:IBacketDiscountStrategy
    {
       public decimal GetTotalCostAfterApplyingDiscoutTo(Backet backet)
       {
           return backet.TotalCost * 0.85m;
       }
    }
}
