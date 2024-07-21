using System;
class Program
{
    static int Toplam(params int[] sayilar)
    {
        if(sayilar.Length == 0)
        {
            return 0;
        }
        int toplam = 0;
        foreach(int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Toplam(2,5,13,7));
        Console.WriteLine(Toplam(1,-1,0,3,-3,7,-7,-4,4));

        Console.ReadLine();
    }
}

