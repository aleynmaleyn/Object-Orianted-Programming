using System;
using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\DOSYA.txt";

            // İlk okuma manuel kapatma ile
            StreamReader reader1 = new StreamReader(filePath);
            string satir1 = reader1.ReadLine();
            reader1.Close();
            reader1.Dispose();
            Console.WriteLine("Manuel kapatma ile okunan satır: " + satir1);

            // İkinci okuma using ile otomatik kapatma
            string satir2;
            using (StreamReader reader2 = new StreamReader(filePath))
            {
                reader2.ReadLine(); // İlk satırı atla
                satir2 = reader2.ReadLine(); // İkinci satırı oku
            }
            Console.WriteLine("Using ile okunan satır: " + satir2);
            Console.ReadLine();
        }
    }
//ReadToEnd(); : son satıra kadar okur,bunu kullanmazsak döngü açıp null olana kadar devam edecektik

//Bu C# kodu, belirtilen dosya yolundaki bir dosyadan bir satır okuma işlemi gerçekleştirir.
//Bu işlemi iki farklı yöntemle yapar: ilkinde manuel kapatma kullanarak,
//ikincisinde ise using ifadesi ile otomatik kapatma kullanarak.

