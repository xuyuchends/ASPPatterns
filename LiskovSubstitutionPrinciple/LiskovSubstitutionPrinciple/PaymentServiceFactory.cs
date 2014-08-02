using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class PaymentServiceFactory
    {
        public static PaymentServiceBase GetPaymentServiceFrom(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.PayPal:
                    return new PayPalPayment("scoot123","abc");
                case PaymentType.WorldPay:
                    return new WorldPayment("scoot123", "abc","1");
                default:
                    return new WorldPayment("scoot123", "abc", "1");
            }
        }
    }
}
