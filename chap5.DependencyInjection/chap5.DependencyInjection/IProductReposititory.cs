using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chap5.DependencyInjection
{
   public  interface IProductReposititory
    {
        List<Product> FindAll();
    }
}
