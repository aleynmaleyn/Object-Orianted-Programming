using System;

namespace hafta6uygulama
{
    class karmasikSayi
    {
        private double gercek;
        private double sanal;
        public double Gercek
        {
            get { return gercek; }
            set { gercek = value; }
        }
        public double Sanal
        {
            get { return sanal; }
            set { sanal = value; }
        }
        public karmasikSayi(double gercek, double sanal)
        {
            this.sanal = sanal;
            this.gercek = gercek;
        }
        public karmasikSayi()
        {
            gercek = 0;
            sanal = 0;
        }
        public karmasikSayi(karmasikSayi k) : this(k.Gercek, k.Sanal)
        {
            Console.WriteLine("Kopyalayıcı kurucu çağrıldı");
        }
        public void yaz()
        {
            if (sanal > 0)
                Console.WriteLine("{0}+{1}i", gercek, sanal);
            else
                Console.WriteLine("{0}-{1}i", gercek, -sanal);
        }
        public static karmasikSayi operator +(karmasikSayi a, karmasikSayi b)
        {
            double gt = a.Gercek + b.Gercek;
            double st = a.Sanal + b.Sanal;
            return new karmasikSayi(gt, st);
        }
        public static karmasikSayi operator +(karmasikSayi a, double b)
        {
            double gt = a.Gercek + b;
            double st = a.Sanal + b;
            return new karmasikSayi(gt, st);
        }
        public static karmasikSayi operator *(karmasikSayi a, karmasikSayi b)
        {
            double sanal1 = a.Gercek * b.Sanal;
            double sanal2 = a.Sanal * b.Gercek;
            double sc = sanal1 + sanal2;
            double gercek1 = a.Gercek * b.Gercek;
            double gercek2 = a.sanal * b.sanal;
            double gc = gercek1 - gercek2;
            return new karmasikSayi(gc, sc);
        }
        public static bool operator ==(karmasikSayi a, karmasikSayi b)
        {
            if (a.Sanal == b.Sanal && a.Gercek == b.Gercek) return true;
            else return false;
        }
        public static bool operator !=(karmasikSayi a, karmasikSayi b)
        {
            return !(a == b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            karmasikSayi k1 = new karmasikSayi(4, 3);
            Console.Write("karmaşık sayı-1:");
            k1.yaz();
            karmasikSayi k2 = new karmasikSayi(4, 3);
            Console.Write("karmaşık sayı-2:");
            k2.yaz();
            Console.Write("k1 ve k2 eşit mi?" + (k1 != k2));
            karmasikSayi k3 = k1 + k2;
            Console.Write("toplam sayı-3:");
            k3.yaz();
            karmasikSayi k5 = new karmasikSayi(k2);
            k5.yaz();
            karmasikSayi k4 = k1 * k2;
            Console.Write("Çarpım:");
            k4.yaz();
            Console.ReadKey();
        }
    }
}