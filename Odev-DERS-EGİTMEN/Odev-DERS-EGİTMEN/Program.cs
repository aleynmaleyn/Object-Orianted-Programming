using System;
using System.Collections.Generic;

namespace Odev_DERS_EGİTMEN
{
    internal class Program
    {
        public class Ders
        {
            public int ID { get; set; }
            public String ders_adı { get; set; }
            public int egitmen_ıd { get; set; }

            public Ders(int ID, string ders_adı, int egitmen_ıd)
            {
                this.ID = ID;
                this.ders_adı = ders_adı;
                this.egitmen_ıd = egitmen_ıd;
            }
        }
        public class Egitmen
        {
            public int ID { get; set; }
            public string egitmen_adı { get; set; }

            private List<Ders> verilen_dersler;

            public Egitmen(int ıD, string egitmen_adı)
            {
                this.ID = ID;
                this.egitmen_adı = egitmen_adı;
                this.verilen_dersler = new List<Ders>();
            }
            public void DersEkle(Ders ders)
            {
                if (verilen_dersler.Count < 20)
                {
                    verilen_dersler.Add(ders);
                }
                else
                {
                    {
                        Console.WriteLine("EN FAZLA 20 DERS OLABİLİR");
                    }
                }
            }
            public void Listele()
            {
                Console.WriteLine($"{egitmen_adı} tarafından verilen dersler: ");

                foreach (var ders in verilen_dersler)
                {
                    Console.WriteLine($"Ders ID: {ders.ID},Ders Adı: {ders.ders_adı}");
                }
            }
        }
        static void Main(string[] args)
        {
            Egitmen egitmen1 = new Egitmen(1, "İlhan AYDIN");
            Egitmen egitmen2 = new Egitmen(2, "Ali Veli");

            Ders ders1 = new Ders(111, "Veri Yapıları", 1);
            Ders ders2 = new Ders(222, "Nesne Tabanlı Programlama", 1);
            Ders ders3 = new Ders(456, "BMG", 2);

            egitmen1.DersEkle(ders1);
            egitmen1.DersEkle(ders2);
            egitmen2.DersEkle(ders3);


            egitmen1.Listele();
            egitmen2.Listele();

            Console.ReadLine();
        }
    }
}
