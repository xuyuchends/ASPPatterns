using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public abstract class PaymentServiceBase
    {
        //delete
        //public abstract string Refund(decimal amount, string transcationID);
        //delete
        //add
        public abstract RefundResponse Refund(decimal amount, string transcationID);
        //add
    }
}
