using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.TemplateMethodPattern
{
   public  class ReturnService
    {
       public void Process(ReturnOrder returnOrder)
       {
           ReturnProcessTemplatecs returnProcessTemplatecs = ReturnProcessFactory.CreateForm(returnOrder.Action);
           returnProcessTemplatecs.Process(returnOrder);

       }
    }
}
