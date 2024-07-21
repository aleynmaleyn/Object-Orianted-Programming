using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        FileInfo dosya = new FileInfo(@"D:\DOSYA.txt");
        if (dosya.Exists)
        {
            Console.WriteLine("Dosya Mevcut.");

            dosya.Delete();
            Console.WriteLine("Dizin Silindi.");
        }
        dosya.Create();
        Console.WriteLine("Dosya oluşturuldu.");
        Console.WriteLine("Oluşturulma Tarihi: " + dosya.CreationTime);
        Console.WriteLine("Bulunduğu Dizinin Adı: " + dosya.DirectoryName);
        Console.WriteLine("Dosya Adı: " + dosya.Name);
        Console.WriteLine("Dosyanın Tam Adı: " + dosya.FullName);
        Console.WriteLine("Son Erişim Tarihi: " + dosya.LastAccessTime);
        Console.WriteLine("Son Değiştirilme Tarihi: " + dosya.LastWriteTime);
        Console.WriteLine("Dosyanın uzantısı: " + dosya.Extension);

        dosya.CopyTo(@"D:\Test");
        Console.ReadLine();
    }
}

