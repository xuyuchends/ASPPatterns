using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Model
{
    /// <summary>
    /// 服务类需要能够将给定的折扣策略应用到一组商品
    /// </summary>
   public static  class ProductListExtensionMethods
    {
       public static void Apply(this IList<Product> products,IDiscountStrategy discountStrategy)
       {
           foreach (Product p in products)
           {
               p.Price.SetDiscountStrategy(discountStrategy);
           }
       }
    }
}
