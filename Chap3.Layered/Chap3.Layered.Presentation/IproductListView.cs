using Chap3.Layered.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Presentation
{
    public interface IproductListView
    {
        void Display(IList<ProductViiewModel> products);
        Model.CustomerType CustomerType { get; }
        string ErrorMessage { set; }
    }
}
