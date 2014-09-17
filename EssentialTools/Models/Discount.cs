using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }
    
    public class DefaultDiscountHelper : IDiscountHelper
    {

        public DefaultDiscountHelper(decimal discountParam)
        {
            discountSize = discountParam;
        }
        public decimal discountSize;
        public decimal ApplyDiscount(decimal totlParam)
        {
            return (totlParam - (discountSize   / 100m * totlParam));
        }
    }
    public class Discount
    {
    }
}