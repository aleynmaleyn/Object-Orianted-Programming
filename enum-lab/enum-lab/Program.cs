using System;
using System.Collections.Generic;
enum KullanimTuru
{
    Is,
    Ozel,
};
enum Tip
{
    fax,
    telefon,
    modem,
}
class Tel
{
    private KullanimTuru kullanimturu;
    private Tip tip;
    private string UlkeKodu;
    private string TelNo;

    public Tel(KullanimTuru kullanimturu, Tip tip, string UlkeKodu, string TelNo)
    {
        this.kullanimturu = kullanimturu;
        this.tip = tip;
        this.UlkeKodu = UlkeKodu;
        this.TelNo = TelNo;
    }
    public override string ToString()
    {
        return $"KullanimTuru: {kullanimturu}, Tip: {tip}, UlkeKodu: {UlkeKodu}, TelNo: {TelNo}";
    }
}

class Ogrenci
{
    public string m_adi;
    public string m_soyadi;
    public DateTime m_datetime;
    public string numara;
    public List<Tel> Telefon = new List<Tel>();
}
class Program
{
    static void Main(string[] args)
    {
        Tel t1 = new Tel(KullanimTuru.Is, Tip.fax, "0", "05412200023");
        Tel t2 = new Tel(KullanimTuru.Ozel, Tip.telefon, "1", "05431307800");

        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Telefon.Add(t1);
        ogrenci.Telefon.Add(t2);

        Console.WriteLine(t1);
        Console.WriteLine(t2);


        Console.ReadLine();
    }
}

