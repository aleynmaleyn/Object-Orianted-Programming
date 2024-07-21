using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo dizin = new DirectoryInfo(@"C:\Test\TestDizini");
        if(dizin.Exists)
        {
            Console.WriteLine("Dizin Mevcut.");

            dizin.Delete();
            Console.WriteLine("Dizin Silindi.");
        }
        dizin.Create();
        Console.WriteLine("Klasör oluşturuldu.");
        Console.WriteLine("Oluşturulma Tarihi: " + dizin.CreationTime);
        Console.WriteLine("Bulunduğu Dizinin Adı: " + dizin.Parent);
        Console.WriteLine("Dizinin Adı: "+dizin.Name);
        Console.WriteLine("Dizinin Tam Adı: "+dizin.FullName);
        Console.WriteLine("Son Erişim Tarihi: "+dizin.LastAccessTime);
        Console.WriteLine("Son Değiştirilme Tarihi: "+dizin.LastWriteTime);
        Console.ReadLine();

        DirectoryInfo altDizin = dizin.CreateSubdirectory("AltDizin");

        Console.WriteLine("{0} dizinindeki dosya sayısı: {1}",dizin.FullName,dizin.GetFiles().Length);
        Console.WriteLine("{0} dizinindeki klasör sayısı: {1}",dizin.FullName,dizin.GetDirectories().Length);
        Console.ReadLine() ;
    }
}

