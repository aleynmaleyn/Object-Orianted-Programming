using System;
using System.IO;
namespace Uygulama_ders
{
    class Cember
    {
        internal double r;
        internal Cember(double r)
        {
            this.r = r;
        }
        internal Cember()
        {
            r = 1;
        }
        internal double AlanHesapla() 
        {
            return Math.PI * r * r;
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\DOSYA\sayilar.txt";
            FileInfo dosya=new FileInfo(path);

            StreamWriter yazici=new StreamWriter(path,true);

            for(int i=0;i<=10;i++) 
            {
                yazici.Write(i+" ");
            }
            yazici.Close();

            Cember c = new Cember(2);//parametreli ve parametresiz iki kurucu metot vardı,parametre verdik ve parametreliyi kullandı.
            Console.Write("ÇEMBERİN YARIÇAPI:{0} VE ALANI:{1}", c.r, c.AlanHesapla());
            Console.ReadKey();
        }
    }
}
