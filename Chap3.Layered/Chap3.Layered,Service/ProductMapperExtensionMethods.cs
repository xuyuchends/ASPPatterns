using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Service
{
   public static class ProductMapperExtensionMethods
    {
       public static IList<ProductViiewModel> ConvertToProductListViiewModel(this IList<Chap3.Layered.Model.Product> products)
       {
           IList<ProductViiewModel> productViiewModels = new List<ProductViiewModel>();
           foreach (Chap3.Layered.Model.Product p in products)
           {
               productViiewModels.Add(p.ConvertToProductViiewModel());
           }
           return productViiewModels;
       }
       public static ProductViiewModel ConvertToProductViiewModel(this Chap3.Layered.Model.Product product)
       {
           ProductViiewModel productViiewModel = new ProductViiewModel();
           productViiewModel.ProductID = product.ID;
           productViiewModel.Name = product.Name;
           productViiewModel.RRP = string.Format("{0:C}", product.Price.RRP);
           productViiewModel.SellingPrice = string.Format("{0:C}", product.Price.SellingPrice);
           if (product.Price.DisCount > 0)
           {
               productViiewModel.DisCount = string.Format("{0:C}", product.Price.DisCount);
           }
           if (product.Price.Savings <1 && product.Price.Savings>0)
           {
               productViiewModel.Savings = product.Price.Savings.ToString("#%");
           }
           return productViiewModel;
       }

    }
}
