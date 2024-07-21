using System;
namespace SecilenDortIslemiYapanUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;
            do
            {
                Console.WriteLine("İKİ SAYI GİR: ");
                int a=Convert.ToInt32(Console.ReadLine());
                int b=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İŞLEM SEÇİMİ: ");
                Console.WriteLine("1-TOPLAMA");
                Console.WriteLine("2-ÇIKARMA");
                Console.WriteLine("3-ÇARPMA");
                Console.WriteLine("4-BÖLME");
                Console.WriteLine("0-ÇIKIŞ");
                
                secim= Convert.ToInt32(Console.ReadLine());

                switch(secim)
                {
                    case 1: Console.WriteLine("{0}+{1}={2}",a,b,(a+b)); break;
                    case 2: Console.WriteLine("{0}-{1}={2}", a, b, (a - b)); break;
                    case 3: Console.WriteLine("{0}*{1}={2}", a, b, (a * b)); break;
                    case 4: Console.WriteLine("{0}/{1}={2}", a, b, (a / b)); break;
                    case 0: Console.WriteLine("ÇIKIŞ SEÇİLDİ.");break;

                    default: Console.WriteLine("YANLIŞ SEÇİM!");break;
                }
            }
            while (secim != 0);
            Console.ReadLine();
        }
    }
}
