using System;
class Program
{
    enum not: byte { basarisiz,gecmez,gecer,orta,iyi,pekiyi}
    static void Main(string[] args)
    {
        Console.Write("Notunuzu girin: ");
        not a = (not)Convert.ToByte(Console.ReadLine());
        Console.WriteLine(a);
        Console.ReadLine();
    }
}

