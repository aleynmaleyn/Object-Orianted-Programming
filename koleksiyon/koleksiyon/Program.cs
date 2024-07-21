using System;
using System.Collections;

namespace koleksiyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ogrenci = new ArrayList();
            ogrenci.Add("Ali");
            ogrenci.Add(5);
            ogrenci.Add(6);
            ogrenci.Remove(5);

            for(int i=0;i< ogrenci.Count; i++)
            {
                Console.WriteLine(ogrenci[i]);
            }
            Console.ReadLine();
        }
    }
}
