using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Model
{
    public interface IProductRepository
    {
       IList<Product> FindAll();
    }
}
