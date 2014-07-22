﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.FactoryPattern
{
   public  class Order
    {
       public decimal TotalCost { get; set; }
       public decimal WeightInKG { get; set; }
       public string  CourierTrackingId { get; set; }
       public Address  DispatchAddress { get; set; }
    }
}
