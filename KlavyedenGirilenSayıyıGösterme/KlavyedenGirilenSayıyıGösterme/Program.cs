using System;

namespace KlavyedenGirilenSayıyıGösterme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KLAVYEDEN GİRİLEN SAYIYI GÖSTERME
            int number;
            Console.Write("Bir sayı girin: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen sayı: {0}",number);
            Console.ReadLine();

            Console.WriteLine("-------------------------");
            
            //İKİ SAYININ ÇARPIMI

            float number1, number2, product;
            Console.Write("Sayı 1: ");
            number1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Sayı 2: ");
            number2 = Convert.ToSingle(Console.ReadLine());

            product = number1 * number2 ;

            Console.WriteLine("Sonuç:  {0}*{1}={2}",number1,number2,product);
            Console.ReadLine();

            Console.WriteLine("-------------------------");

            //İKİ SAYINI TOPLAMI

            int number3, number4, sum;
            Console.Write("Birinci sayıyı girin: ");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin: ");
            number4 = Convert.ToInt32(Console.ReadLine());

            sum=number3 + number4;
            Console.WriteLine("Sonuç=" +sum);
            //Console.ReadKey();//bu metod yazıldığında,başka bir tuşa bastığımda sonuç ekrandan gidiyor.

            Console.WriteLine("-------------------------");

            //İKİ SAYIYI BÖLME

            float number5, number6, product2,kalan;
            Console.Write("1. sayı: ");
            number5 = Convert.ToSingle(Console.ReadLine());
            Console.Write("2. sayı:");
            number6 = Convert.ToSingle(Console.ReadLine());

            product2 = number5 / number6;
            Console.WriteLine("{0}/{1}={2}", number5, number6, product2);
            kalan= number5 % number6;
            Console.WriteLine("KALAN: " + kalan);

            Console.ReadLine();

            Console.WriteLine("-------------------------");

            /*BÖLÜM SONUCU KALAN BULMA

            int bolunen = 59, bolen = 8;
            int bolum = bolunen / bolen;
            int kalan = bolunen % bolen;

            Console.WriteLine("bolunen:{0} bolen:{1}", bolunen, bolen);
            Console.WriteLine("bolum= " + bolum);
            Console.WriteLine("kalan= " + kalan);
            Console.ReadLine();*/
        }
      
    }
}
