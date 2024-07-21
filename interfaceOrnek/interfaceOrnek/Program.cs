using System;
namespace InterfaceOrnek
    {
        interface IDersler
        {
            void DersEkle();


        }
        class Mufredat2021 : IDersler
        {
            public void DersEkle()
            {
                Console.WriteLine("Ders 2021 Müfredatına Göre Eklendi");
            }
        }
        class Mufredat2024 : IDersler
        {
            public void DersEkle()
            {
                Console.WriteLine("Ders 2024 Müfredatına Göre Eklendi");
            }
        }
        internal class Program
        {

            static void Main(string[] args)
            {
                Mufredat2021 eskiMufredat = new Mufredat2021();
                eskiMufredat.DersEkle();
                Mufredat2024 yeniMufredat = new Mufredat2024();
                yeniMufredat.DersEkle();

                Console.ReadLine();
            }
        }
    }
