using System;
using System.Windows.Forms;

namespace GirilenArlıktakiSayilariToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtbaşlangıç.KeyPress += new KeyPressEventHandler(SadeceSayi_KeyPress); // SadeceSayi_KeyPress metodu klavyeden sadece sayı girişine izin verir
            txtbitiş.KeyPress += new KeyPressEventHandler(SadeceSayi_KeyPress);
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtbaşlangıç.Text, out int baslangic) || !int.TryParse(txtbitiş.Text, out int bitis))
            {
                MessageBox.Show("Başlangıç ve bitiş değerleri geçerli bir tam sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbaşlangıç.Clear();
                txtbitiş.Clear();
                return;
            }

            if (bitis <= baslangic)
            {
                MessageBox.Show("Bitiş değeri başlangıç değerinden büyük olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbaşlangıç.Clear();
                txtbitiş.Clear();
                txtbaşlangıç.Focus(); // Başlangıç değerine odaklan,imleç oraya gelir sıfırlandıktan sonra.
                return;
            }

            int tekToplam = 0;
            int ciftToplam = 0;
            int genelToplam = 0;

            for (int i = baslangic; i <= bitis; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
                genelToplam += i;
            }

            tektoplam.Text = tekToplam.ToString();
            çifttoplam.Text = ciftToplam.ToString();
            geneltoplam.Text = genelToplam.ToString();
        }

        private void SadeceSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı girişine izin verir
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbaşlangıç_TextChanged(object sender, EventArgs e)
        {
            tektoplam.Clear();
            çifttoplam.Clear();
            geneltoplam.Clear();
        }

        private void txtbitiş_TextChanged(object sender, EventArgs e)
        {
            tektoplam.Clear();
            çifttoplam.Clear();
            geneltoplam.Clear();
        }
    }
}
