
using System.Windows.Forms;

namespace _1_100ArasıTekCiftSayılarınToplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tekToplam = 0, ciftToplam = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
            MessageBox.Show("TEK SAYILARIN TOPLAMI= " + tekToplam +
                            "\nÇİFT SAYILARIN TOPLAMI=  " + ciftToplam +
                            "\nTÜM SAYILARIN TOPLAMI= " + (tekToplam + ciftToplam));
        }
    }
}
