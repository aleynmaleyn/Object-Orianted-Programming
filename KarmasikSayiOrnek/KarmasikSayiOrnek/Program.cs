using System;
class KarmasikSayi
{
    private double ReelKısım;
    private double SanalKısım;

    public double Gercek
    {
        get { return ReelKısım; }
        set { ReelKısım = value; }
    }
    public double Sanal
    {
        get { return SanalKısım; }
        set { SanalKısım = value; }
    }
    public KarmasikSayi(double x, double y)
    {
        ReelKısım = x;
        SanalKısım = y;
    }
    public KarmasikSayi()
    {
        ReelKısım = 0;
        SanalKısım = 0;
    }
    public KarmasikSayi(KarmasikSayi k)
    {
        ReelKısım = k.ReelKısım;
        SanalKısım = k.SanalKısım;
    }
    public void Yaz()
    {
        if (SanalKısım > 0)
        {
            Console.WriteLine("{0}+{1}i",ReelKısım,SanalKısım);
        }
        else
        {
            Console.WriteLine("{0}-{1}i", ReelKısım, -SanalKısım);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        KarmasikSayi k=new KarmasikSayi(5,6);
        k.Yaz();
        Console.ReadLine();
    }
}

