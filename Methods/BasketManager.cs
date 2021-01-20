using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        // Naming Convention
        //Syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!:"+ product.Name);

        }
        public void Add2(string productName, string Description, double Price, int Stocks)
        {
            Console.WriteLine("Tebrikler Ürün Sepete Eklendi : " + productName);

        }
    }
}
