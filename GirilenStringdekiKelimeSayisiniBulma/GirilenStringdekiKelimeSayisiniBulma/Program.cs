using System;

namespace GirilenStringdekiKelimeSayisiniBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cümle;
            Console.Write("Metin girin: ");
            cümle = Console.ReadLine();
            string[] kelime = cümle.Split(' ');
            Console.WriteLine("Kelime sayısı: " + kelime.Length);
            Console.ReadKey();
        }
    }
}
