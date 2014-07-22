using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.TemplateMethodPattern
{
    /// <summary>
    /// 办理退货的订单
    /// </summary>
    public class ReturnOrder
    {
        /// <summary>
        /// 退货单的类型
        /// </summary>
        public ReturnAction Action { get; set; }
        /// <summary>
        /// 订单的原始支付
        /// </summary>
        public string PaymentTransactionID { get; set; }
        /// <summary>
        /// 订单总价
        /// </summary>
        public decimal PricePaid { get; set; }
        /// <summary>
        /// 运费
        /// </summary>
        public decimal PostageCost { get; set; }
        /// <summary>
        /// 退货产品ID
        /// </summary>
        public long ProductID { get; set; }
        /// <summary>
        /// 退还给客户的总金额
        /// </summary>
        public decimal AmountToRefund { get; set; }
    }
}
