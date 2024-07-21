using System;

namespace Odev_POLINOM
{
    class Polinom
    {
        public int terimSayisi;
        public int[] katsayilar;
        public int[] kuvvetler;

        public Polinom(int terimSayisi, int[] katsayilar, int[] kuvvetler)
        {
            this.terimSayisi = terimSayisi;
            this.katsayilar = katsayilar;
            this.kuvvetler = kuvvetler;
        }

        public void PolinomYaz(Polinom polinom) // Polinomu ekrana yazdırma
        {
            for (int i = 0; i < polinom.terimSayisi; i++)
            {
                if (polinom.katsayilar[i] != 0)
                {
                    if (i > 0 && polinom.katsayilar[i] > 0)
                    {
                        Console.Write(" + ");
                    }

                    if (polinom.kuvvetler[i] == 0)
                    {
                        Console.Write($"{polinom.katsayilar[i]}");
                    }
                    else if (polinom.kuvvetler[i] == 1)
                    {
                        Console.Write($"{polinom.katsayilar[i]}x");
                    }
                    else
                    {
                        Console.Write($"{polinom.katsayilar[i]}x^{polinom.kuvvetler[i]}");
                    }
                }
            }
            Console.WriteLine();
        }

        public bool polinomKontrol(Polinom polinom) // Polinomun sıfır olup olmadığı kontrolü
        {
            foreach (int katsayi in polinom.katsayilar)
            {
                if (katsayi != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool polinomKontrol(Polinom P1, Polinom P2) // İki polinomun eşit olup olmadığı kontrolü
        {
            if (P1.terimSayisi != P2.terimSayisi)
            {
                return false;
            }
            for (int i = 0; i < P1.terimSayisi; i++)
            {
                if (P1.katsayilar[i] != P2.katsayilar[i] || P1.kuvvetler[i] != P2.kuvvetler[i])
                {
                    return false;
                }
            }
            return true;
        }

        public Polinom KopyaOlustur() // Polinomun kopyasını oluşturur
        {
            int[] katsayiKopya = new int[this.terimSayisi];
            int[] kuvvetKopya = new int[this.terimSayisi];
            Array.Copy(this.katsayilar, katsayiKopya, this.terimSayisi);
            Array.Copy(this.kuvvetler, kuvvetKopya, this.terimSayisi);
            return new Polinom(this.terimSayisi, katsayiKopya, kuvvetKopya);
        }

        public void katsayilariArttir(int n) // Polinomun katsayılarını n kadar arttırır
        {
            for (int i = 0; i < this.terimSayisi; i++)
            {
                if (this.kuvvetler[i] != 0) // Sabit terim değilse arttır
                {
                    this.katsayilar[i] += n;
                }
            }
        }

        public void sabitDegerArttir(int n) // Polinomun sabit katsayısını n kadar arttır
        {
            this.katsayilar[this.terimSayisi - 1] += n; // Sabit terimi arttır
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Polinom P1 = new Polinom(3, new int[] { 1, 2, 5 }, new int[] { 4, 2, 0 });
            Polinom P2 = new Polinom(2, new int[] { 3, 6 }, new int[] { 3, 0 });

            Console.Write("P1:");
            P1.PolinomYaz(P1);
            Console.Write("P2:");
            P2.PolinomYaz(P2);

            Console.WriteLine("P1 sıfır mı? " + P1.polinomKontrol(P1));
            Console.WriteLine("P2 sıfır mı? " + P1.polinomKontrol(P2));

            Console.WriteLine("P1 ve P2 eşit mi? " + P1.polinomKontrol(P1, P2));

            Polinom P1Kopya = P1.KopyaOlustur(); // P1'in kopyasını oluştur
            Polinom P2Kopya = P2.KopyaOlustur(); // P2'nin kopyasını oluştur

            /*kopya oluşturmayı,katsayıları arttırırken,sabit değeri arttırılmış olan
            polinomdan değil,ilk başta tanımlanan polinomdan artttırsın diye ekledim.
            */
            Console.Write("P1'in sabit değerini 8 artır:");
            P1.sabitDegerArttir(8);
            P1.PolinomYaz(P1);

            Console.Write("P1'in katsayılarını 2 artır:");
            P1Kopya.katsayilariArttir(2);
            P1Kopya.PolinomYaz(P1Kopya);

            Console.Write("P2'nin sabit değerini 8 artır:");
            P2.sabitDegerArttir(8);
            P2.PolinomYaz(P2);

            Console.Write("P2'nin katsayılarını 2 artır:");
            P2Kopya.katsayilariArttir(2);
            P2Kopya.PolinomYaz(P2Kopya);

            Console.ReadLine();
        }
    }
}
