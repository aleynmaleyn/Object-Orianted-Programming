using System;

public class Uye
{
    private string[] Uyeler = { "Aleyna", "Veysel", "Ayşe", "Neriman" };
    public string this[int Index]
    {
        get
        {
            if (Index < 0 || Index >= Uyeler.Length)
            {
                return null;
            }
            else
            {
                return Uyeler[Index];
            }
        }
        set
        {
            if (!(Index < 0) || Index >= Uyeler.Length)
            {
                Uyeler[Index] = value;
            }
        }
    }
    public int this[string aranan]
    {
        get
        {
            for (int i = 0; i < Uzunluk; i++)
            {
                if (aranan.Equals(Uyeler[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
    public int Uzunluk
    {
        get { return Uyeler.Length; }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Uye uye = new Uye();
        Console.WriteLine(uye[0]);
        uye[0] = "Zehra";

        for (int i = 0; i < uye.Uzunluk; i++)
        {
            Console.WriteLine(uye[i]);
        }
        if (uye["Veysel"] >= 0)
        {
            Console.WriteLine("Aranan dizide var: {0}", uye["Veysel"]);
        }
        else
        {
            Console.WriteLine("Aranan dizide yok.");
        }
        Console.ReadKey();

    }
}

