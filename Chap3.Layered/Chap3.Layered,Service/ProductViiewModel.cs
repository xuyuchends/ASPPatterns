using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Service
{
   public class ProductViiewModel
    {
       public int ProductID { get; set; }
       public string Name { get; set; }
       public string RRP { get; set; }
       public string SellingPrice { get; set; }
       public string Savings { get; set; }
       public string DisCount { get; set; }
    }
}
