using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 商品价格默认行为
    /// </summary>
   public  class BasePrice:IPrice
    {
       public decimal Cost { get; set; }
    }
}
