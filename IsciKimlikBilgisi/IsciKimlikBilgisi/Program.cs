using System;
using System.Collections.Generic;
using System.Windows.Forms;
public class KimlikBilgisi
{
    public ulong TCKimlik { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string AdSoyad
    {
        get
        {
            string adSoyad = (this.Ad + " " + this.Soyad).ToUpper();
            return adSoyad;
        }
    }
    public string DogumYeri { get; set; }
    public DateTime DogumTarihi { get; set; }
}
public class Isci
{
    public int SirketKimlikNo { get; set; }
    public decimal Maas { get; set; }

    public KimlikBilgisi Kimlik { get; set; }
}
public class Fabrika
{
    public string Ad { get; set; }
    private List<Isci> Calisanlar { get; set; } = new List<Isci>();
    public void CalisanEKle(Isci isci)
    {
        Calisanlar.Add(isci);
    }
    public List<Isci> CalisanlariListele()
    {
        return Calisanlar;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fabrika fabrika = new Fabrika();
            fabrika.Ad = "Seyrek Fabrikası";

            KimlikBilgisi kimlik = new KimlikBilgisi();
            kimlik.TCKimlik = 154861;
            kimlik.Ad = "Ahmet";
            kimlik.Soyad = "Demir";
            kimlik.DogumYeri = "İzmir";

            Isci isci = new Isci();
            isci.Kimlik = kimlik;
            isci.SirketKimlikNo = 954;
            isci.Maas = 50000;

            fabrika.CalisanEKle(isci);

            string mesaj = $"Ad Soyad: {isci.Kimlik.AdSoyad}\n" +
                      $"Kimlik No: {isci.Kimlik.TCKimlik}\n" +
                      $"Şirket Kimlik No: {isci.SirketKimlikNo}\n" +
                      $"Maaş: {isci.Maas}\n" +
                      $"Doğum Tarihi: {isci.Kimlik.DogumTarihi.ToShortDateString()}";
            MessageBox.Show(mesaj);


        }
    }
}

