
using System;

class Kutu
{
    public double length;//uzunluk
    public double breadth;//genişlik
    public double height;//yükseklik

}
class Program
{
    static void Main(string[] args)
    {
        Kutu kutu1 = new Kutu();
        Kutu kutu2 = new Kutu();

        double hacim;

        kutu1.height = 5.0;
        kutu1.length = 6.0;
        kutu1.breadth = 7.0;

        kutu2.height = 10.0;
        kutu2.length = 12.0;
        kutu2.breadth = 13.0;

        hacim = kutu1.height * kutu1.length * kutu1.breadth;
        Console.WriteLine("Kutu1'in hacmi: {0}", hacim);

        hacim=kutu2.height*kutu2.length*kutu2.breadth;
        Console.WriteLine("Kutu2'nin hacmi: {0}", hacim);

        Console.ReadKey();  
    }
}

