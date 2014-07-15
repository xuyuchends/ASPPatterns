using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3.Layered.Model
{
  public   class Price
    {
      private IDiscountStrategy discountStrategy = new NullDiscountStrategy();
      /// <summary>
      /// 建议零售价
      /// </summary>
      private decimal rrp;
      /// <summary>
      /// 卖的价格
      /// </summary>
      private decimal sellingPrice;
      public Price(decimal rrp, decimal sellingPrice)
      {
          this.rrp = rrp;
          this.sellingPrice = sellingPrice;
      }
      public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
      {
          this.discountStrategy = discountStrategy;
      }
      public decimal SellingPrice
      {
          get
          {
              return discountStrategy.ApplyExtraDiscontsTo(sellingPrice);
          }
      }
      public decimal RRP
      {
          get
          {
              return rrp;
          }
      }
      /// <summary>
      /// 折扣
      /// </summary>
      public decimal DisCount
      {
          get
          {
              if (RRP > SellingPrice)
              {
                  return RRP - SellingPrice;
              }
              else
              {
                  return 0;
              }
          }
      }
      /// <summary>
      /// 节约的百分比
      /// </summary>
      public decimal Savings
      {
          get
          {
              if (RRP > SellingPrice)
              {
                  return 1 - (SellingPrice / RRP);
              }
              else
              {
                  return 0;
              }
          }
      }
    }
}
