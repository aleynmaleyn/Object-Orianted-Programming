using System;

class Program
{
    public enum Renkler : byte { Siyah, Beyaz, Kırmızı, Mavi, Sarı }
}
class Sınıf
{
    enum Gunler: byte { Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar}
    static void Main()
    {
        string[] a = Gunler.GetNames(typeof(Gunler));
        Console.WriteLine(a[0]);//veya
        Console.WriteLine(Gunler.GetNames(typeof(Gunler))[3]);

        Program.Renkler b = (Program.Renkler)1;
        Console.WriteLine(b+","+(byte)b);

        Console.ReadLine();
    }
}

