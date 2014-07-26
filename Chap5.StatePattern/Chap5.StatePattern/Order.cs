using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.StatePattern
{
   public  class Order
    {
       private IOrderState orderState;
       public Order(IOrderState orderState)
       {
           this.orderState = orderState;
       }
       public int ID { get; set; }
       public string Customer { get; set; }
       public DateTime OrderdDate { get; set; }
       public OrderStatus Status()
       {
           return orderState.Status;
       }

       internal void Change(IOrderState orderState)
       {
           throw new NotImplementedException();
       }
    }
}
