using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class LinqValueCalculyator:IValueCalculator 
    {
        public decimal ValueProducts(IEnumerable<Product > products)
        {
            return products.Sum(p => p.Price);
        }
    }
}