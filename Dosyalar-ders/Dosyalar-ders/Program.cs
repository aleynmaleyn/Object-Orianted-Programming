using System;


namespace Dosyalar_ders
{
    internal class Program
    {
        static void metot1(int x,int y) //2 parametre için çalışır bu metot.
        {
            Console.WriteLine("metot1 çağırıldı.");
        }
        static void metot1(int x,params int[]y) //kaç parametre gönderirsen gönder buna,her türlü çalışır. aynı metot ismiyle yaptık buna aşırı yükleme denir.
        {
            Console.WriteLine("Diğer metot çağırıldı.");
        }
        static int topla(int[] dizi,out double ortalama)//dizinin elemanlarını toplayıp geri döndüren bir metot.
        {
            int toplam = 0;
            foreach(int sayi in dizi)
            {
                toplam += sayi;
            }
            ortalama = (double)toplam / dizi.Length;//burada toplamı double almazsan değeri int verir dikkat et.
            return toplam;
        }
        static void Main(string[] args)
        {
            metot1(2, 3,5);
            //Console.ReadLine();

            int[] d = {1,3,4,7,8,15 };
            double ortalama;

            int toplam = topla(d,out ortalama);//out toplam metodundan direkt ortalama bulmaya yarayacak.
            Console.WriteLine("TOPLAM= "+toplam);
            //Console.ReadLine();
            Console.WriteLine("ORTALAMA= " + ortalama);
            Console.ReadLine();

            //params
            //out:direkt hafızada işlemi grçekleştiriyor. 
            //ref: outla çok benzer,tek farkı ortalamayı tanımlamanmızı,başlangıç değeri atamamızı ister.
        }
    }
}
