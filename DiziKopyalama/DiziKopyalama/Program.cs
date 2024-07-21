using System;
namespace DiziKopyalama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] dizi2 = new int[10];
            int[] dizi3 = { 99, 88, 77, 66, 55, 44, 33, 22, 11, 00, -55, -43 };


            //dizi1'i,dizi2'nin 2.indisinden itibaren kopyalar ve dizi boyutunu dolurmak için boş indislere 0 yazar.
            dizi1.CopyTo(dizi2, 2);
            foreach (int i in dizi2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //dizi1'in 2.indisinden itibaren kopyalar.
            //dizi3'ün 5.indisten başlayarak 3 indisine kopyalar.5,6 ve 7. indislere yani.

            Array.Copy(dizi1, 2, dizi3, 5, 3);
            foreach (int i in dizi3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

