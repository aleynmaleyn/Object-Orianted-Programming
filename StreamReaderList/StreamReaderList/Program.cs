using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string filepath = @"D:\DOSYA.txt";
        List<string> list = new List<string>();
        using (StreamReader reader = new StreamReader(filepath))
        {
            string satir;
            while ((satir = reader.ReadLine()) != null)
            {
                list.Add(satir);
                Console.WriteLine(satir);
            }
            Console.ReadLine();
        }
    }
}

