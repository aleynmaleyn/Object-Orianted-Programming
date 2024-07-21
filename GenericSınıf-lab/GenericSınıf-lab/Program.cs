using System;

namespace GenericSınıf_lab
{
    class Cocuk<T, K>
    {
        private T m_id;
        private T m_agirlik;
        private K m_adi;
        private K m_soyadi;

        public T Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public T Agirlik
        {
            get { return m_agirlik; }
            set { m_agirlik = value; }
        }
        public K Adi
        {
            get { return m_adi; }
            set { m_adi = value; }
        }
        public K Soyadi
        {
            get { return m_soyadi; }
            set { m_soyadi = value; }
        }

        public Cocuk(T id, T agirlik, K adi, K soyadi)
        {
            m_id = id;
            m_agirlik = agirlik;
            m_adi = adi;
            m_soyadi = soyadi;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cocuk<byte, string> cocuk1 = new Cocuk<byte, string>(1, 250, "Ali", "Veli");
            Cocuk<string, string> cocuk2 = new Cocuk<string, string>("1", "560", "Ayşe", "Fatma");

            Console.WriteLine($"Cocuk1 - Id: {cocuk1.Id}, Agirlik: {cocuk1.Agirlik}, Adi: {cocuk1.Adi}, Soyadi: {cocuk1.Soyadi}");
            Console.WriteLine($"Cocuk2 - Id: {cocuk2.Id}, Agirlik: {cocuk2.Agirlik}, Adi: {cocuk2.Adi}, Soyadi: {cocuk2.Soyadi}");

            Console.ReadLine();
        }
    }
}
