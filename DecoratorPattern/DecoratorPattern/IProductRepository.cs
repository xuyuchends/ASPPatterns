﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
   public  interface IProductRepository
    {
        IList<Product> FindAll();
    }
}
