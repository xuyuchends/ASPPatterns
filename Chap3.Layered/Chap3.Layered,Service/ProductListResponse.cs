using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Service
{
   public  class ProductListResponse
    {
       public bool Success { get; set; }
       public string Message { get; set; }
       public IList<ProductViiewModel> Products { get; set; }
    }
}
