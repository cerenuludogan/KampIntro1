using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array-dizi[]
            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi","Programlamaya baslangic icin temel kurs", "Java",
                "Python","C++"};

            for(int i = 1; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach(string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
