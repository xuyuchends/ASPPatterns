using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered_Service
{
  public   class ProductService
    {
      private Chap3.Layered.Model.ProductService productService;
      public ProductService(Chap3.Layered.Model.ProductService productService)
      {
          this.productService = productService;
      }
      public ProductListResponse GetAllProductFor(ProductListRequest productListRequest)
      {
          ProductListResponse productListResponse = new ProductListResponse();
          try
          {
              IList<Chap3.Layered.Model.Product> products = productService.GetAllProductFor(productListRequest.CustomerType);
              productListResponse.Products = products.ConvertToProductListViiewModel();
              productListResponse.Success = true;
          }
          catch (Exception ex)
          {
              productListResponse.Success = false;
              productListResponse.Message = "An error occurred";

          }
          return productListResponse;
      }
    }
}
