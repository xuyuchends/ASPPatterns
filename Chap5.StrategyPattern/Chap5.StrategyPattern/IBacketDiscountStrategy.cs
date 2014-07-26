using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.StrategyPattern
{
   public  interface IBacketDiscountStrategy
    {
       decimal GetTotalCostAfterApplyingDiscoutTo(Backet backet);
    }
}
