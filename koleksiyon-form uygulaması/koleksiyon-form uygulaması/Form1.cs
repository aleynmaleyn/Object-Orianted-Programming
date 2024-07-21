using System;
using System.Collections; // ArrayList TANIMLAMAK İÇİN KOLEKSİYONLARI KULLANDIK.
//BİRBİRİYLE İLİŞKİLİ NESNELERİ TANIMLAMAK İÇİN DİZİ VE KOLEKSİYONLAR KULLANILIR
//DİZİLERİN ÇALIŞMA ZAMANINDA BOYUTLARININ ARTMAMASI DEZAVANTAJIDIR
//KOLEKSİYONLAR,ÇALIŞMA ZAMANINDA BOYUTU DEĞİŞTİRİLEBİLEN VERİ TİPLERİDİR
//ARRAYLİST BİR SINIFTIR VE BU SINIFTAN TÜRETEBİLECEĞİMİZ SINIFLARLA NESNELER SAKLANABİLİR.
//BOYUT ATAMASI YAPARSAK O BOYUT KADAR KULLANABİLİRİZ,YAPMAZSAK İSTEDĞİMİZ KADAR BOYUT KULLANABİLRİZ

using System.Windows.Forms;

namespace koleksiyon_form_uygulaması
{
    public partial class Form1 : Form
    {
        ArrayList liste;

        public Form1()
        {
            InitializeComponent();
            liste = new ArrayList();
        }

        private void listele()
        {
            listBox1.Items.Clear(); // ListBox'ı temizle
            for (int i = 0; i < liste.Count; i++)
            {
                listBox1.Items.Add(liste[i]);
            }
            Console.WriteLine("KAPASİTE: " + liste.Capacity);//kapasiteyi yazdırır.
            Console.WriteLine("ELEMAN SAYISI: " + liste.Count);//ArrayList dizisindeki eleman sayısını verir.
        }

        private void button1_Click(object sender, EventArgs e)//EKLE BUTONU
        {
            string isim = textBox1.Text.ToLower(); // İsimleri küçük harfe çevir
            if (!string.IsNullOrEmpty(isim))
            {
                if (!liste.Contains(isim))
                {
                    liste.Add(isim);
                }
                else
                {
                    MessageBox.Show(isim + " zaten listede var.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir isim giriniz.");
            }

            listele();
            textBox1.Clear(); // TextBox'ı temizle
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)//sil butonu
        {
            string isim = textBox1.Text.ToLower(); // İsimleri küçük harfe çevir
            if (!string.IsNullOrEmpty(isim))
            {
                if (liste.Contains(isim))
                {
                    liste.Remove(isim);//verilen nesne ArrayListte varsa onu sil.
                }
                else
                {
                    MessageBox.Show(isim + " zaten listede yok");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir isim giriniz.");
            }

            listele();
            textBox1.Clear(); // TextBox'ı temizle
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)//ARAYA EKLE BUTONU
        {
            string isim = textBox1.Text.ToLower(); // İsimleri küçük harfe çevir
            if (!string.IsNullOrEmpty(isim))
            {
                if (!liste.Contains(isim))//Contains true false bool değer döndürür.
                {
                    if (liste.Count > 0) // Aksi durumda liste boş demektir
                    {
                        liste.Insert(1, isim); //İNSERT GİRİLEN İNDİSE EKLEME YAPAR
                    }
                    else
                    {
                        liste.Add(isim); // Liste boş olduğu için araya eklenemedi ve listeye ekledik ismi
                    }
                }
                else
                {
                    MessageBox.Show(isim + " zaten listede var.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir isim giriniz.");
            }

            listele();
            textBox1.Clear(); // TextBox'ı temizle
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)//ARADAN SİL BUTONU
        {
            if (liste.Count > 2) // Listenin en az 3 eleman içerdiğini kontrol et ,ÇÜNKÜÜ 2.İNDİSTEKİNİ SİLDİRİYORUZ,EN AZ 3 ELEMAN İÇERMEK ZORUNDA BU  YÜZDEN
            {
                liste.RemoveAt(2);//Veilen indisteki değeri siler.
                listele(); // Listeyi güncelle 
            }
            else
            {
                MessageBox.Show("Liste en az 3 eleman içermelidir, 2. indisteki eleman silinemedi.");
            }
            textBox1.Clear(); // TextBox'ı temizle
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();//Uygulamayı kapat
        }
    }
}
