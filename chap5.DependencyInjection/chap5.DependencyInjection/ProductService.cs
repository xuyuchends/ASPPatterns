using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chap5.DependencyInjection
{
   public  class ProductService
    {
      // private ChristmasProductDiscount christmasProductDiscount;
       private IproductDiscountStrategy christmasProductDiscount;
      // private LinqProductReposititory linqProductReposititory;
       private IProductReposititory linqProductReposititory;
       //public ProductService()
       public ProductService(IProductReposititory linqProductReposititory)
       {
           christmasProductDiscount = new ChristmasProductDiscount();
           
           //linqProductReposititory = new LinqProductReposititory();
           this.linqProductReposititory = linqProductReposititory;
       }
       //public List<Product> GetProducts()
       //{
       //    List<Product> products = linqProductReposititory.FindAll();
       //    foreach (Product p in products)
       //    {
       //        p.AdjectPriceWith(christmasProductDiscount);
       //    }
       //    return products;
       //}
       public List<Product> GetProducts(IproductDiscountStrategy discount)
       {
           List<Product> products = linqProductReposititory.FindAll();
           foreach (Product p in products)
           {
               p.AdjectPriceWith(discount);
           }
           return products;
       }
    }
}
