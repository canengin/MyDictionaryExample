using System;

namespace MyDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> Uyeler = new MyDictionary<string>();

            Uyeler.Add("Kütüphane Kulübü");
            Console.WriteLine(Uyeler.Length);
            Uyeler.Add("Satranç Kulübü");
            Console.WriteLine(Uyeler.Length);
            Uyeler.Add("Spor Kulübü");
            Console.WriteLine(Uyeler.Length);
            Uyeler.Add("Sağlık Kulübü");
            Console.WriteLine(Uyeler.Length);
            Uyeler.Add("Girişimcilik Kulübü");
            Console.WriteLine(Uyeler.Length);

            foreach (var uye in Uyeler.Items)
            {
                Console.WriteLine(uye);
            }
            Console.ReadLine();
        }
    }
}
