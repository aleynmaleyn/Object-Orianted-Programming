using System;
namespace DiziElemanlariSiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = { "aleyna","veysel","zehra","yiğit","emir"};
            Console.WriteLine("DİZİ ELEMANLARI: ");
            foreach (string d in dizi)
            {
                Console.WriteLine(d);
            }
            Array.Sort(dizi);

            Console.WriteLine("\nSIRALANMIŞ DİZİ: ");
            foreach(string d in dizi)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }
    }
}
