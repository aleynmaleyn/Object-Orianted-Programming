using System;
namespace ınterface_2_animasyon
{
    public interface IAnimasyonlar
    {
        void Yuru();
        void SagaDon();
        void SolaDon();
        void Kos();
    }
    public interface UcanAnımasyon
    {
        void Uc();
        void YereIn();

    }

        public class YavasKarakter:IAnimasyonlar
    {
        public void Yuru()
        {
            Console.WriteLine("YAVAŞ KARAKTER YÜRÜDÜ.");
        }
        public void SagaDon()
        {
            Console.WriteLine("YAVAŞ KARAKTER SAĞA DÖNDÜ");
        }
        public void SolaDon()
        {
            Console.WriteLine("YAVAŞ KARAKTER SOLA DÖNDÜ.");
        }
        public void Kos()
        {
            Console.WriteLine("YAVAŞ KARAKTER KOŞTU");
        }
    }
    public class HızlıKarakter: IAnimasyonlar
    {
        public void Yuru()
        {
            Console.WriteLine("HIZLI KARAKTER YÜRÜDÜ.");
        }
        public void SagaDon()
        {
            Console.WriteLine("HIZLI KARAKTER SAĞA DÖNDÜ");
        }
        public void SolaDon()
        {
            Console.WriteLine("HIZLI KARAKTER SOLA DÖNDÜ.");
        }
        public void Kos() 
        {
            Console.WriteLine("HIZLI KARAKTER KOŞTU");
        }
    }
    public class UcanKarakter : UcanAnımasyon
    {
        public void Uc()
        {
            Console.WriteLine("UÇAN KARAKTER UÇTU");
        }
        public void YereIn()
        {
            Console.WriteLine("UÇAN KARAKTER YERE İNDİ");
        }
        public void SagaDon()
        {
            Console.WriteLine("UÇAN KARAKTER SAĞA DÖNDÜ");
        }    }

    internal class Program
    {
        static void Main(string[] args)
        {
            YavasKarakter yavasKarakter= new YavasKarakter();
            yavasKarakter.Yuru();
            yavasKarakter.SagaDon();


            HızlıKarakter hızlıKarakter = new HızlıKarakter();
            hızlıKarakter.SolaDon();
            hızlıKarakter.Kos();

            UcanKarakter ucanKarakter = new UcanKarakter();
            ucanKarakter.SagaDon();
            ucanKarakter.YereIn();

            Console.ReadLine();
        }
    }
}
