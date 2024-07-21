using System;
using System.Windows.Forms;


namespace Uygulama_ders_araba
{
    public partial class Form1 : Form
    {
        Galeri galeri;//formun her yerinden erişmek istediğimiz için burada tanımlama yaptık
        public Form1()
        {
            InitializeComponent();
            galeri = new Galeri();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string renk = textBox3.Text;

            Araba araba = new Araba(marka, model, renk);
            galeri.ArabaEkle(araba);

            MessageBox.Show("EKLEME YAPILDI");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] liste = galeri.ArabaListele();
            foreach (string item in liste)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
