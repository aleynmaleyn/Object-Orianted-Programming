using System;
using System.Collections.Generic;
namespace ListCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 2, 3, 5, };

            List<int> list = new List<int>(dizi);//List' e kopyala.
            Console.WriteLine(list.Count);
            Console.ReadLine();
        }
    }
}
