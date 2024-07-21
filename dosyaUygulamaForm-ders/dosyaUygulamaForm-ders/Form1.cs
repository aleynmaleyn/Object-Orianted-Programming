//okunan dosyadaki noktalama işaretlerini temizleyen kod

using System;

using System.Windows.Forms;
using System.IO;

namespace dosyaUygulamaForm_ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosyaoku_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\DOSYA\\dosya.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                textBox1.Text = textBox1.Text + " " + line.ToString();
                line = sr.ReadLine();

            }
            sr.Close();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            char[] noktalama = {'.',',',':',';','"','*','-','+','*' };
            string metin = textBox1.Text;
            string temizMetin = "";

            foreach(char karakter in metin)
            {
                bool varMi = false;
                for(int i = 0; i < noktalama.Length; i++)
                {
                    if (karakter == noktalama[i])
                    {
                        varMi = true;
                        break;//karakter noktalama işsaretlerinden biriyse iç dömgüyü sonlandır.
                    }
                }
                if (!varMi)
                {
                    temizMetin += karakter;
                }

            }
            textBox2.Text = temizMetin;
            }
        }
    }

