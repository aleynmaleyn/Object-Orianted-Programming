using System;
using System.Collections.Generic;

namespace Dictionary_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir Dictionary oluşturuluyor
            Dictionary<int, string> yeniListe = new Dictionary<int, string>();

            // Dictionary'ye öğeler ekleniyor
            yeniListe.Add(0, "Aleyna");
            yeniListe.Add(1, "Veysel");
            yeniListe.Add(2, "Neriman");

            // Dictionary'deki öğeleri ekrana yazdır
            Console.WriteLine("Dictionary içeriği:");
            foreach (var item in yeniListe)
            {
                Console.WriteLine($"Anahtar: {item.Key}, Değer: {item.Value}");
            }

            // Anahtar 2 ile olan öğeyi kaldır
            bool removed = yeniListe.Remove(2);

            // Kaldırma işleminin başarılı olup olmadığını kontrol et
            if (removed)
            {
                Console.WriteLine("Anahtar 2 başarıyla kaldırıldı.");
            }
            else
            {
                Console.WriteLine("Anahtar 2 bulunamadı.");
            }

            // Güncellenmiş Dictionary içeriğini ekrana yazdır
            Console.WriteLine("\nGüncellenmiş Dictionary içeriği:");
            foreach (var item in yeniListe)
            {
                Console.WriteLine($"Anahtar: {item.Key}, Değer: {item.Value}");
            }

            // Kullanıcının bir tuşa basmasını bekle
            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}

