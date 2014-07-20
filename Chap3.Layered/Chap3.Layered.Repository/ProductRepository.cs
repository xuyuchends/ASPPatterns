using Chap3.Layered.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IList<Product> FindAll()
        {
            IList<Product> products = new List<Product>();
            Product p1 = new Product();
            p1.ID = 1;
            p1.Name = "p1";
            p1.Price = new Price(1,2);
            Product p2 = new Product();
            p2.ID = 2;
            p2.Name = "p2";
            p2.Price = new Price(2, 4);
            Product p3 = new Product();
            p3.ID = 3;
            p3.Name = "p3";
            p3.Price = new Price(3, 6);
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            return products;
        }
    }
}
