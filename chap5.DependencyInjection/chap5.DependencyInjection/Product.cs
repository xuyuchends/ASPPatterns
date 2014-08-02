using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chap5.DependencyInjection
{
   public  class Product
    {
       //public void AdjectPriceWith(ChristmasProductDiscount discount)
       //{ }
       public void AdjectPriceWith(IproductDiscountStrategy discount)
        { }
    }
}
