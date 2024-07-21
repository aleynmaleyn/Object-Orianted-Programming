using System;
using System.Collections;

namespace ArrayListLab
{
    class DiziArrayList
    {
        private int k = 0;
        private int[] dizi = new int[5];
        private ArrayList liste = new ArrayList();

        public void DiziAta(int a)
        {
            if (k < dizi.Length)
            {
                dizi[k] = a;
                k++;
            }
            else
            {
                Console.WriteLine("Dizi dolu, eleman eklenemiyor.");
            }
        }

        public void DiziAta(object a)
        {
            liste.Add(a);
        }

        public void DiziYazdir(int[] a)
        {
            foreach (int eleman in a)
            {
                Console.WriteLine(eleman);
            }
        }

        public void DiziYazdir()
        {
            foreach (object eleman in liste)
            {
                Console.WriteLine(eleman);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] yeniDizi = { 1, 2, 3, 4, 5 };
            DiziArrayList d = new DiziArrayList();

            for (int i = 0; i < 5; i++)
            {
                d.DiziAta(yeniDizi[i]);
            }
            d.DiziYazdir(yeniDizi);

            string s = "123";
            int c = 123;

            d.DiziAta((object)s);
            d.DiziAta((object)c);

            d.DiziYazdir();

            Console.ReadLine();
        }
    }
}
