using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
public    class RefundRequest
    {
    public PaymentType Payment { get; set; }
    public string PaymentTransactionID { get; set; }
    public decimal RefundAmount { get; set; }
    }
}
