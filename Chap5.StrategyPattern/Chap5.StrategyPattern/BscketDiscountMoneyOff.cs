using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.StrategyPattern
{
    /// <summary>
    /// 折扣策略
    /// </summary>
   public  class BscketDiscountMoneyOff:IBacketDiscountStrategy
    {
       public decimal GetTotalCostAfterApplyingDiscoutTo(Backet backet)
       {
           if (backet.TotalCost > 100)
           {
               return backet.TotalCost - 10;
           }
           else if (backet.TotalCost > 50)
           {
               return backet.TotalCost - 5;
           }
           else
           {
               return backet.TotalCost;
           }
        }
    }
}
