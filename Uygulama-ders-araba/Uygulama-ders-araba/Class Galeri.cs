
using System.Collections.Generic;
 class Galeri
{
    private List<Araba> arabalar;
    public Galeri()
    {
        arabalar = new List<Araba>();
    }
    public void ArabaEkle(Araba araba)
    {
        arabalar.Add(araba);
    }
    public string[] ArabaListele()
    {
        string[] liste = new string[arabalar.Count];//eklenen arba sayısı kadar string dizisi oluşturur.

        for (int i = 0; i < liste.Length; i++)
        {
            liste[i] = arabalar[i].Marka + " " + arabalar[i].Model + " " + arabalar[i].Renk;
        }
        return liste;
    }
}

