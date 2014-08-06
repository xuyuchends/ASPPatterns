using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class OrderService
    {
        public void CreateKuaiDi(Order order)
        {
            KuaiDi kai = KuaiDiFunctory.CreateKuaiDiFunctory(order);
            order.DispatchAddress = kai.AddressByKuaiDi();
        }
    }
}
