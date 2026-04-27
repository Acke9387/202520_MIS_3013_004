using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Stock_Sales
{
    public class StockOption
    {

        public object BuyerName { get; set; }
        public object PurchasePrice { get; set; }
        public object SalePrice { get; set; }
        public object StockSymbol { get; set; }
        public object PurchaseDate { get; set; }
        public object SaleDate { get; set; }

        public StockOption()
        {
            
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }

}
