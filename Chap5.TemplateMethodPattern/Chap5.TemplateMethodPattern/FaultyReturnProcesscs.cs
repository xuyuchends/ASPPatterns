using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.TemplateMethodPattern
{
   public  class FaultyReturnProcesscs:ReturnProcessTemplatecs
    {
       protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
       {
           
       }
       protected override void CalculateRefundFor(ReturnOrder returnOrder)
       {
           returnOrder.AmountToRefund = returnOrder.PricePaid + returnOrder.PostageCost;
       }
    }
}
