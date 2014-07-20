
using Chap3.Layered.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Presentation
{
   public  class ProductListPresenter
    {
       private IproductListView productListView;
       private ProductService productService;
       public ProductListPresenter(IproductListView productListView, Chap3.Layered.Service.ProductService productService)
       {
           this.productListView = productListView;
           this.productService = productService;
       }
       public void Display()
       {
           ProductListRequest productListRequest = new ProductListRequest();
           productListRequest.CustomerType = productListView.CustomerType;
           ProductListResponse productListResponse = productService.GetAllProductFor(productListRequest);
           if (productListResponse.Success)
           {
               productListView.Display(productListResponse.Products);
           }
           else
           {
               productListView.ErrorMessage = productListResponse.Message;
           }

       }
    }
}
