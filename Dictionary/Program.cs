using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> sehirler = new MyDictionary<string,int>();
            sehirler.Add("Antalya", 30000);
            sehirler.Add("İzmir", 250000);

            Console.WriteLine(sehirler.Lenght);

            foreach (var sehir in sehirler.itemkey)
            {
                Console.WriteLine(sehir);
            }

            foreach (var nufus in sehirler.itemvalue)
            {
                Console.WriteLine(nufus);
            }
        }
    }
}
