using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.StrategyPattern
{
    /// <summary>
    /// 特殊折扣， null object
    /// </summary>
    public class BacketNoDiscount : IBacketDiscountStrategy
    {
        public decimal GetTotalCostAfterApplyingDiscoutTo(Backet backet)
        {
            return backet.TotalCost;
        }
    }
}
