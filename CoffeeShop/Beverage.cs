using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public enum CupSize
    {
        Small,
        Medium,
        large,
        X_large
    }
    public abstract class Beverage
    {
        public string CusName { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public CupSize CupSize { get; set; }

    }
}
