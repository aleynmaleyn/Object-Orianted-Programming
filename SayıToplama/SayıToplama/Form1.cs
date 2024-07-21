using System;
using System.Windows.Forms;

namespace SayıToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void EkranıAyarla(bool toplamBasarili=false)
        {
            if (!toplamBasarili)
            {
                textBox1.Text = textBox2.Text = textBox3.Text = "0";
                textBox1.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool dogrulamaSonucu = Dogrula();
         
            if (dogrulamaSonucu)
            {
                int toplam = Topla(Convert.ToInt32(textBox1.Text),
                           Convert.ToInt32(textBox2.Text));


                textBox3.Text = toplam.ToString();
                //MessageBox.Show("TOPLAM= " + toplam);
            }
            else
            {
                MessageBox.Show("GİRDİĞİNİZ DEĞERLER HATALI.");

                EkranıAyarla(dogrulamaSonucu);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
            {
                e.Handled = true;
            }
        }
    }
}
