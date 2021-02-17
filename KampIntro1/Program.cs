using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 8.45;
            double dolarBugun = 7.50;

            if(dolarBugun > dolarDun)
            {
                Console.WriteLine("Artis butonu");
            }
            else if(dolarBugun < dolarDun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
           

        }
    }
}
