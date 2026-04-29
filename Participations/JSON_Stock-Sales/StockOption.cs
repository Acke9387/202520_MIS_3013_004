using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Stock_Sales
{
    public class StockOption
    {

        public string BuyerName { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public string StockSymbol { get; set; }
        public string PurchaseDate { get; set; }
        public string SaleDate { get; set; }

        public StockOption()
        {
            BuyerName = string.Empty;
            PurchasePrice = 0;
            SalePrice = 0;
            StockSymbol = string.Empty;
            PurchaseDate = string.Empty;
            SaleDate = string.Empty;
        }


        public override string ToString()
        {
           return $"Buyer: {BuyerName}, Stock: {StockSymbol}, Purchase Price: {PurchasePrice.ToString("C")}, Sale Price: {SalePrice.ToString("C")}, Purchase Date: {PurchaseDate}, Sale Date: {SaleDate}";
        }

        public bool IsProfit()
        {
            return SalePrice > PurchasePrice;
        }
    }

}
