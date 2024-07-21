using System;
class Program
{
    static void BitYaz(int b)
    {
        if (b == 0)
        {
            return;
        }
        BitYaz(b >> 1);
        Console.Write(b & 1);//ikiye bölümünden kalan sonucu yazar.
    }
    static void Main(string[] args)
    {
        BitYaz(15);
        Console.WriteLine();
        BitYaz(32);
        Console.ReadLine();
    }
}

