using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.FactoryPattern
{
    public class OrderService
    {
        public void Dispatch(Order order)
        {
            IShippingCourier shippingCourier = UKShippingCourierFactoty.CreateShippingCourier(order);
            order.CourierTrackingId = shippingCourier.GenerateConsignmentLaberFor(order.DispatchAddress);
        }
    }
}
