using System;
using System.Collections.Generic;

namespace Odev_ÇİKOLATA_KUTUSU
{
    internal class Program
    {
        public static int SatilanCikolataSayisiHesaplama(int N, int[] C)
        {
            Stack<int>yıgın= new Stack<int> ();
            int toplamSatilan = 0;

            for(int i=0;i<N;i++)
            {
                if (C[i] == 0)//kutu satılacak
                {
                    if(yıgın.Count>0)//yıgın boş değilse
                    {
                        toplamSatilan += yıgın.Pop();

                        //c[i]=0 ise ve stack boş değilse stackin en üstündekini çıkar.
                        //ve toplamSatilan'ı çıkarılanın değeri kadar arrtır.
                    }
                    
                }
                else
                {
                    yıgın.Push(C[i]);  

                    //c[i]>0 ise c[i]'nin eşit olduğuğu değer kadar çikolata içeren bir kutuyu stacka at.
                }
            }
            return toplamSatilan;

        }
        static void Main(string[] args)
        {
            int N = 9;
            int[] C = { 3, 0, 2, 1, 4 ,4,0,9,1};

            int result=SatilanCikolataSayisiHesaplama (N,C);

            Console.WriteLine("Satılan ÇİKOLATA SAYISI: "+result);
            Console.ReadLine();
        }
    }
}
