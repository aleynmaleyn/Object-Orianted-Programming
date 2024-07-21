using System;
class Universite
{
    enum bolumler
    {
        YazilimMuh,
        ElektrikMuh,
        MekatronikMuh,
        BilgisayarMuh,
        MakineMuh,
    }
    static void Main(string[] args)
    {
        bolumler b;
        for (b = bolumler.YazilimMuh; b <= bolumler.MakineMuh; b++)
        {
            Console.WriteLine("{0} etiketi={1,4:d}", b, (int)b);
        }
        Console.ReadLine();
    }
}

