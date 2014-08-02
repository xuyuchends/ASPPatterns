using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class PayPalPayment : PaymentServiceBase
    {
        //add
        public PayPalPayment(string amountName, string password)
        {
            this.AmountName = amountName;
            this.Password = password;
        }
        //add

        public string AmountName { get; set; }
        public string Password { get; set; }
        //public override string Refund(decimal amount, string transcationID)
        //{
        //    MockPayWebservice payPalwebService = new MockPayWebservice();
        //    string token = payPalwebService.ObtainToken(AmountName, Password);
        //    string response = payPalwebService.MakeRefund(amount, transcationID, token);
        //    return response;
        //}
        public override string Refund(decimal amount, string transcationID)
        {
            RefundResponse refundResponse = new RefundResponse();
            MockPayWebservice payPalwebService = new MockPayWebservice();
            string token = payPalwebService.ObtainToken(AmountName, Password);
            string response = payPalwebService.MakeRefund(amount, transcationID, token);
            refundResponse.Message = response;
            if ( refundResponse.Message.Contains("Auth"))
            {
                refundResponse.Succcess = true;
            }
            else
            {
                refundResponse.Succcess = false;
            }
            return refundResponse;
        }
    }
}
