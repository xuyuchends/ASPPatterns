using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
   public static  class ProdctCollectionExtensionMethods
    {
       public static void ApplyCurrencyPriceDecoratorcs(this IList<Product> products)
       {
           foreach (Product p in products)
           {
               p.Price = new CurrencyPriceDecoratorcs(p.Price, 0.78m);
           }
       }
       public static void ApplyTradeDiscountDecoratorcs(this IList<Product> products)
       {
           foreach (Product p in products)
           {
               p.Price = new TradeDiscountPriceDecorator(p.Price);
           }
       }
    }
}
