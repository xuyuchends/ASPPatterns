using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.StatePattern
{
    /// <summary>
    /// 被发货的订单不能发货，也不能再取消
    /// </summary>
    public class OrderShippedState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }
        public void Ship(Order order)
        {
            //can't Ship
        }
        public bool CanCancel(Order order)
        {
            return false;
        }
        public void Cancel(Order order)
        {
            //can't Cancel
        }
        public OrderStatus Status
        {
            get
            {
                return OrderStatus.Shipped;
            }
        }
    }
}
