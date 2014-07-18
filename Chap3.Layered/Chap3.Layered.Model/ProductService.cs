using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Model
{
    /// <summary>
    /// 客户端和领域交互的服务类
    /// </summary>
   public  class ProductService
    {
       private IProductRepository productRepository;
       public ProductService(IProductRepository productRepository)
       {
           this.productRepository = productRepository;
       }
       public IList<Product> GetAllProductFor(CustomerType customerType)
       {
           IDiscountStrategy discountStrategy = DiscountFactory.GetDiscountStrategyFor(customerType);
           IList<Product> products = productRepository.FindAll();
           products.Apply(discountStrategy);
           return products;

       }
    }
}
