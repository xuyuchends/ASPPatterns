using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class RefundService
    {
        public RefundResponse Refund(RefundRequest refundRequest)
        {
            PaymentServiceBase paymentService = PaymentServiceFactory.GetPaymentServiceFrom(refundRequest.Payment);
            RefundResponse refundResponse = new RefundResponse();
            //if ((paymentService as PayPalPayment) != null)
            //{
            //    ((PayPalPayment)paymentService).AmountName = "AmountName";
            //    ((PayPalPayment)paymentService).Password = "Password";
            //}
            //if ((paymentService as WorldPayment) != null)
            //{
            //    ((WorldPayment)paymentService).AccountID = "AccountID";
            //    ((WorldPayment)paymentService).AccountPassword = "AccountPassword";
            //    ((WorldPayment)paymentService).ProductID = "ProductID";

            //}
            //string response = paymentService.Refund(refundRequest.RefundAmount, refundRequest.PaymentTransactionID);
            //refundResponse.Message = response;
            //if (refundResponse.Message.Contains("A_Success") || refundResponse.Message.Contains("Auth"))
            //{
            //    refundResponse.Succcess = true;
            //}
            //else
            //{
            //    refundResponse.Succcess = false;
            //}
            //return refundResponse;
            refundResponse = paymentService.Refund(refundRequest.RefundAmount, refundRequest.PaymentTransactionID);
            return refundResponse;

        }
    }
}
