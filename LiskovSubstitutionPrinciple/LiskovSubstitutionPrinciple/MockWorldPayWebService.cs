using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
   public  class MockWorldPayWebService
    {
        public string MakeRefund(decimal amount, string transactionID,string username,string password, string productID)
        {
            return "A_Susscess:09903";
        }
    }
}
