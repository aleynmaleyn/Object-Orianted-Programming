using System;

namespace Odev_KOOORDİNAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Points point = new Points();
            point.Atama(2, 7);
            point.Yazdirma();

            int koordinatX = point.GeriDondurX();
            Console.WriteLine("x koordinatı: " + koordinatX);
            int koordinatY = point.GeriDondurY();
            Console.WriteLine("y koordinatı: " + koordinatY);

            Console.ReadLine();

        }
    }

    public class Points
    {
        private int x;
        private int y;

        public void Atama(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Yazdirma()
        {
            Console.WriteLine("KOORDİNATLAR: " + "(" + x + "," + y + ")");
        }
        public int GeriDondurX()
        {
            return x;
        }
        public int GeriDondurY()
        {
            return y;
        }
    }
}
