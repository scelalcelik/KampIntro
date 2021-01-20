using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Elma";
            double Price = 15;
            string Description = "Amasya elması";
            string[] Fruits = new string[] { };

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("------------------------------------------------------");
            }
            Console.WriteLine("---------------------------Methods----------------------------");

            //instance - Örnek
            //encapsulation -Kapsülleme Düzensiz bir yapıyı bir düzene sokma bir kapsüle sokma
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
            basketManager.Add2("Armut", "Sarı Armut", 12, 10);
            basketManager.Add2("Elma", "Yeşil Elma", 15, 8);
            basketManager.Add2("Karpuz", "Diyarbakır Karpuzu", 18, 9);
            //Ürünlerde bir düzenleme yapıldığında 2. yöntem sorun çıkarır. Bu yüzden classlardan yararlanmak çok daha mantıklıdır



        }
    }
}


//Do not repeat yourself - DRY - Clean Code - Best Practice
