using System;
using System.Windows.Forms;
public class Hali
{
    private int alan;
    public int Alan
    {
        get
        {
            AlanHesapla();
            return alan;
        }
    }
    public int Genislik { get; set; }
    public int Uzunluk {  get; set; }
    private void AlanHesapla()
    {
        alan = Uzunluk * Genislik;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Hali halı= new Hali();
        halı.Genislik = 4;
        halı.Uzunluk = 3;
        MessageBox.Show("Alan: " + halı.Alan);
    }
}

