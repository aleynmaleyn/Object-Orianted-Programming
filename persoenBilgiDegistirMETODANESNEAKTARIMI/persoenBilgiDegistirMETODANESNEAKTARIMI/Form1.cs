using System;
using System.Windows.Forms;
namespace persoenBilgiDegistirMETODANESNEAKTARIMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Personel
        {
            public string Ad;
            public string Soyad;
        }
        private void PersonelBilgiDegisstir(Personel p)
        {
            p.Ad = p.Ad.ToUpper();
            p.Soyad = p.Soyad.ToUpper();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();

            personel.Ad = textBox1.Text;
            personel.Soyad = textBox2.Text;

            PersonelBilgiDegisstir(personel);

            textBox1.Text = personel.Ad;
            textBox2.Text = personel.Soyad;
        }
    }
}
