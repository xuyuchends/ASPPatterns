using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 打折行为
    /// </summary>
   public  class TradeDiscountPriceDecorator:IPrice
    {
       private IPrice basePrice;
       public TradeDiscountPriceDecorator(IPrice price)
       {
           basePrice = price;
       }
       public decimal Cost
       {
           get
           {
               return basePrice.Cost * 0.95m;
           }
           set
           {
               basePrice.Cost = value;
           }
       }
    }
}
