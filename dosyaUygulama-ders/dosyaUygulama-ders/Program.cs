using System;

using System.Text;

using System.IO;

namespace Dosya
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //dosya yazma
            int x;
            try
            {

                StreamWriter sw = new StreamWriter("C:\\DOSYA\\dosya.txt", true, Encoding.ASCII);//dosyanın nerede olacağını gösteriri , true ibaresi ise ustüne yazmayı aktifleştirir , hangi formatta kodlanacak
                for (int i = 0; i <= 10; i++)
                {
                    sw.Write(i + " ");
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata :" + ex.Message);
            }



            //dosya okuma
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\DOSYA\\dosya.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata :" + ex.Message);
            }
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}