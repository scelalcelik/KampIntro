using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        /* void -> İşlem sonucunda ortaya çıkan sonuç başka bir yerde kullanılmak istenmiyorsa void kullanılır.
         * Eğer çıkan sonuç başka bir yerde kullanılacaksa int kullanılmalıdır.
    */
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }
        public int Topla(int number1, int number2)
        {
            return number1 + number2;


        }
        public void Topla2(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        /* public void BiseyYap(int sayi)
         {
             sayi = 99;
         }*/
    }
}
