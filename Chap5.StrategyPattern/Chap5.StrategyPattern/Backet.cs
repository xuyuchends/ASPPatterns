using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.StrategyPattern
{
    public class Backet
    {
        public decimal TotalCost { get; set; }
        private IBacketDiscountStrategy backetDiscountStrategy;
        public Backet(DiscountType discountType)
        {
            backetDiscountStrategy = BacketDiscountFactory.GetDiscount(discountType);
        }
        public decimal GetTotalCostAfterDiscout()
        {
            return backetDiscountStrategy.GetTotalCostAfterApplyingDiscoutTo(this);
        }
    }
}
