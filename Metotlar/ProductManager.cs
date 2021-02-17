using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class ProductManager
    {
        public void ProductAdd(Product product)
        {
            Console.WriteLine(product.Adi + " sepete eklendi");
        }
    }
}
