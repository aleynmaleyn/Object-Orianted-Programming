using System;
using System.Windows.Forms;

namespace Uygulama_ders_personel
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Degistir(Personel personel)
        {
            personel.Ad=personel.Ad.ToUpper();
            personel.Soyad=personel.Soyad.ToUpper();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Ad=textBox1.Text;
            personel.Soyad=textBox2.Text;

            Degistir(personel);

            textBox1.Text=personel.Ad;
            textBox2.Text=personel.Soyad;
        }
    }
}
