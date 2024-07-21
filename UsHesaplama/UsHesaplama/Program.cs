using System;

namespace UsHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taban, us;

            Console.Write("TABAN DEĞERİ GİRİN: ");
            taban=Convert.ToDouble(Console.ReadLine());

            Console.Write("ÜS DEĞERİ GİRİN: ");
            us = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0}^{1}={2}",taban, us,Math.Pow(taban,us));
            Console.ReadKey();
        }
    }
}
