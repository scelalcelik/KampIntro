using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInsStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInsStock = 5,
                ProductName = "Kalem", UnitPrice = 35 };

            // PascalCase -- Classlarda Kelimelerin ilk harfi büyük olur
            //camelCase -- Değişkenlerde ilk kelime küçük diğerleri büyük harfle başlar
            //case sensitive -- Java C# gibi diller büyük küçük harf duyarlıdır.

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            // Console.WriteLine(product1.ProductName); ? -- Kamera -- Referans tip oldugundan

            /*int sayi = 100;
             productManager.BiseyYap(sayi);
            // Console.WriteLine(sayi); ? -- 100 -- Deger tip oldugundan*/

            //int double bool ... değer tip
            //diziler,class,abstract,interface ... referans tip

            productManager.Topla2(3, 6);
            productManager.Topla(3, 6);
        }
    }
}
