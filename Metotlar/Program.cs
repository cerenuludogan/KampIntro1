using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 10;
            string aciklama = "Amasya elmasi";

            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 10;
            product1.Aciklama = "Amasya elmasi";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 40;
            product2.Aciklama = "Diyarbakir karpuzu";

            Product[] products = new Product[] {product1,product2 };

            //type-safe
            foreach(var product  in products){
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("-------Metotlar---------");

            ProductManager productManager = new ProductManager();

            productManager.ProductAdd(product1);
            productManager.ProductAdd(product2);




        }
    }
}
