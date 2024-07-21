using System;
using System.Windows.Forms;

namespace DortgenPrizma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class DortgenPrizma
        {
            private float en;
            private float boy;
            private float yukseklik;

            public float HacimHesapla(float EN,float BOY,float YUKSEKLİK)
            {
                en= EN; ;
                boy= BOY;
                yukseklik = YUKSEKLİK;

                return(en*boy*yukseklik);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DortgenPrizma prizma=new DortgenPrizma();

            float hacim = prizma.HacimHesapla(4,5,7);

            MessageBox.Show("HACİM: " + hacim.ToString());

        }
    }
}
