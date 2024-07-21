using System;

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filepath = @"D:\DOSYA.txt";

        //mevcut dosya varsa üstüne açar
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            writer.Write("aleyna");
            writer.Write("veysel");
            writer.Write("mayhoş");

        }
        //dosya yoksa yeni açar
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            writer.WriteLine("Satır 1");
        }
        //mevcut dosyaya satır ekler
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            writer.WriteLine("Satır 2");
        }
        Console.ReadLine();

    }
}
