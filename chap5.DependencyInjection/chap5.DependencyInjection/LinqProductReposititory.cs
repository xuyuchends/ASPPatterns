using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chap5.DependencyInjection
{
   public  class LinqProductReposititory
       :IProductReposititory//add
    {
       public List<Product> FindAll()
       {
           return new List<Product>();
       }
    }
}
