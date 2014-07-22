using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
   public  class CurrencyPriceDecoratorcs:IPrice
    {
       private IPrice basePrice;
       private decimal exchangeRate;
       public CurrencyPriceDecoratorcs(IPrice price, decimal exchangeRate)
       {
           basePrice = price;
           this.exchangeRate=exchangeRate;
       }
       public decimal Cost
       {
           get
           {
               return basePrice.Cost * exchangeRate;
           }
           set
           {
               basePrice.Cost = value;
           }
       }
    }
}
