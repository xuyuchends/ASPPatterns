using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.StatePattern
{
    /// <summary>
    /// 新建的的订单能发货，也能取消
    /// </summary>
    public class OrderNewState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return true ;
        }
        public void Ship(Order order)
        {
            order.Change(new OrderShippedState());
        }
        public bool CanCancel(Order order)
        {
            return true;
        }
        public void Cancel(Order order)
        {
            order.Change(new OrderCancelState());
        }
        public OrderStatus Status
        {
            get
            {
                return OrderStatus.New;
            }
        }
    }
}
