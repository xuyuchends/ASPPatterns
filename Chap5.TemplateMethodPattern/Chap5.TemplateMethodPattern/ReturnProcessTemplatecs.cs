using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.TemplateMethodPattern
{
    public abstract class ReturnProcessTemplatecs
    {
        protected abstract void GenerateReturnTransactionFor(ReturnOrder returnOrder);
        protected abstract void CalculateRefundFor(ReturnOrder returnOrder);

        public void Process(ReturnOrder returnOrder)
        {
            GenerateReturnTransactionFor(returnOrder);
            CalculateRefundFor(returnOrder);
        }
    }
}
