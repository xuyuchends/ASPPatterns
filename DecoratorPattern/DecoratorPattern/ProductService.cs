using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
   public  class ProductService
    {
       private IProductRepository productRepository;
       public ProductService(IProductRepository productRepository)
       {
           this.productRepository = productRepository;
       }
        public IList<Product> GetAllProducts()
        {
            IList<Product> Products = productRepository.FindAll();
            Products.ApplyTradeDiscountDecoratorcs();
            Products.ApplyCurrencyPriceDecoratorcs();
            return Products;
       }
    }
}
