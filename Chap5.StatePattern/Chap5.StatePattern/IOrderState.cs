using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.StatePattern
{
    public interface IOrderState
    {
        bool CanShip(Order order);
        void Ship(Order order);
        bool CanCancel(Order order);
        void Cancel(Order order);
    }
}
