using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
   public  class KuaiDiFunctory
    {
       public static KuaiDi CreateKuaiDiFunctory(Order order)
       {
           if (order.TotalCost > 100)
           {
               return new ShunFeng();
           }
           else
           {
               return new ZhongTong();
           }
       }
    }
}
