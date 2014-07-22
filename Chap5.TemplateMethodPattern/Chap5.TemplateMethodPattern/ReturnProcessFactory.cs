using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.TemplateMethodPattern
{
   public static  class ReturnProcessFactory
    {
       public static ReturnProcessTemplatecs CreateForm(ReturnAction returnAction)
       {
           switch (returnAction)
           {
               case ReturnAction.FaulyReturn:
                   return new FaultyReturnProcesscs();
               case ReturnAction.NoQuibblesReturn:
                   return new NoQuibblesReturnProcess();
               default:
                   return new NoQuibblesReturnProcess();
           }
       }
    }
}
