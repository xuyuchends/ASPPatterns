using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
   public class MockPayWebservice
    {
       public string ObtainToken(string accountName, string password)
       {
           return "xxxxxxxx-xxxxxxxxxx-xxxxx";
       }
       public string MakeRefund(decimal amount, string transactionID, string token)
       {
           return "Auth:999";
       }
    }
}
