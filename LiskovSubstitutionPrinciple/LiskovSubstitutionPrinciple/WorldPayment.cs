using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class WorldPayment : PaymentServiceBase
    {
        public string AccountID { get; set; }
        public string AccountPassword { get; set; }
        public string ProductID { get; set; }

        //add
        public WorldPayment(string accountID, string accountPassword, string productID)
        {
            this.AccountID = accountID;
            this.AccountPassword = accountPassword;
            this.ProductID = productID;
        }
        //add
        //public override string Refund(decimal amount, string transcationID)
        //{
        //    MockWorldPayWebService worldPayWebService = new MockWorldPayWebService();
        //    string response = worldPayWebService.MakeRefund(amount, transcationID, AccountID, AccountPassword, ProductID);
        //    return response;
        //}
        public override RefundResponse Refund(decimal amount, string transcationID)
        {
            RefundResponse refundResponse = new RefundResponse();
            MockWorldPayWebService worldPayWebService = new MockWorldPayWebService();
            string response = worldPayWebService.MakeRefund(amount, transcationID, AccountID, AccountPassword, ProductID);
            refundResponse.Message = response;
            if (refundResponse.Message.Contains("A_Success"))
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
