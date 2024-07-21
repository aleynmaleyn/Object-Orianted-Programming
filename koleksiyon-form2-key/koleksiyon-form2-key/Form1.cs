
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace koleksiyon_form2_key
{
    public partial class Form1 : Form
    {
        Hashtable ht = new Hashtable();

        public Form1()
        {
            InitializeComponent();
        }

        private void listele()
        {
            listBox1.Items.Clear();
            foreach (DictionaryEntry entry in ht)
            {
                listBox1.Items.Add(entry.Key + " - " + entry.Value);
            }
            MessageBox.Show("ELEMAN SAYISI: " + ht.Count);
        }

        private void button1_Click(object sender, EventArgs e) // ekle butonu
        {
            string anahtar = textBox1.Text.Trim();
            string isim = textBox2.Text.ToLower().Trim();

            if (!string.IsNullOrEmpty(anahtar) && !string.IsNullOrEmpty(isim))
            {
                if (!ht.ContainsKey(anahtar))
                {
                    ht.Add(anahtar, isim);
                    MessageBox.Show("Öğe eklendi: " + anahtar + " - " + isim);
                }
                else
                {
                    MessageBox.Show("Bu anahtar zaten var.");
                }
            }
            else
            {
                MessageBox.Show("Anahtar ve değer boş olamaz.");
            }

            listele();
            textBox1.Clear(); // TextBox'ı temizle
            textBox2.Clear(); // İkinci TextBox'ı da temizle
            textBox1.Focus();
        }
        private void button2_Click_1(object sender, EventArgs e) // sil butonu
        {

            {
                string anahtar = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(anahtar))
                {
                    if (ht.ContainsKey(anahtar))
                    {
                        ht.Remove(anahtar);
                        MessageBox.Show("Öğe silindi: " + anahtar);
                    }
                    else
                    {
                        MessageBox.Show("Bu anahtar bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Anahtar boş olamaz.");
                }

                listele();
                textBox1.Clear(); // TextBox'ı temizle
                textBox1.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)// çıkış butonu
        {
            Application.Exit(); // Uygulamayı kapat
        }

        private void button6_Click_1(object sender, EventArgs e)//listele butonu
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)// araya ekle butonu
        {
            {
                string yeniAnahtar = textBox1.Text.Trim();
                string yeniIsim = textBox2.Text.ToLower().Trim();

                if (!string.IsNullOrEmpty(yeniAnahtar) && !string.IsNullOrEmpty(yeniIsim))
                {
                    if (!ht.ContainsKey(yeniAnahtar))
                    {
                        // Geçici bir listeye kopyalayarak anahtarlara göre sıralama yap
                        List<DictionaryEntry> geciciListe = new List<DictionaryEntry>(ht.Count + 1);
                        foreach (DictionaryEntry eleman in ht)
                        {
                            geciciListe.Add(eleman);
                        }

                        geciciListe.Add(new DictionaryEntry(yeniAnahtar, yeniIsim));
                        geciciListe.Sort((x, y) => string.Compare(x.Key.ToString(), y.Key.ToString(), StringComparison.Ordinal));

                        // Hashtable'ı temizleyip, sıralı listeyi geri yükle
                        ht.Clear();
                        foreach (var eleman in geciciListe)
                        {
                            ht.Add(eleman.Key, eleman.Value);
                        }

                        MessageBox.Show("Öğe eklendi: " + yeniAnahtar + " - " + yeniIsim);
                    }
                    else
                    {
                        MessageBox.Show("Bu anahtar zaten var.");
                    }
                }
                else
                {
                    MessageBox.Show("Anahtar ve değer boş olamaz.");
                }

                listele();
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
        private void button4_Click(object sender, EventArgs e)//aradan sil
        {
            string hedefAnahtar = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(hedefAnahtar))
            {
                if (ht.ContainsKey(hedefAnahtar))
                {
                    List<DictionaryEntry> geciciListe = new List<DictionaryEntry>(ht.Count - 1);
                    foreach (DictionaryEntry eleman in ht)
                    {
                        if (eleman.Key.ToString() != hedefAnahtar)
                        {
                            geciciListe.Add(eleman);
                        }
                    }

                    ht.Clear();
                    foreach (var eleman in geciciListe)
                    {
                        ht.Add(eleman.Key, eleman.Value);
                    }

                    MessageBox.Show("Öğe silindi: " + hedefAnahtar);

                    // TextBox'ları temizle
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Bu anahtar bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Anahtar boş olamaz.");
            }

            listele();
            textBox1.Focus();
        }
    }
}