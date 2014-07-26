using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.StrategyPattern
{
    public class BacketDiscountFactory
    {
        public static IBacketDiscountStrategy GetDiscount(DiscountType  discountType)
        {
            switch (discountType)
            {
                case DiscountType.MoneyOff:
                    return new BscketDiscountMoneyOff();
                case DiscountType.PercentageOff:
                    return new BacketDiscountPercentageOff();
                default :
                    return new BacketNoDiscount();

            }
        }
    }
}
