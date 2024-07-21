using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<int>liste = new List<int>(new int[] { 19, 23, 29,47 });
            int indis = liste.IndexOf(29);
            Console.WriteLine(indis);
            Console.ReadLine();
        }
    }

