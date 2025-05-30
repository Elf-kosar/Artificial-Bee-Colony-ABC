using System;
using System.Linq;
using System.Windows.Forms;

namespace ABC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int koloniBoyutu = (int)KoloniBoyutu.Value;

            int altSinir = (int)AltSinir.Value;
            int ustSinir = (int)UstSinir.Value;
            int cevrimSayisi = (int)CevrimSayisi.Value;
            int denemeSayisi = (int)DenemeSayisi.Value;

            chartEniyi.Series["X1"].Points.Clear();
            chartEniyi.Series["X2"].Points.Clear();
            chartFx.Series["Fx"].Points.Clear();

            chartEniyi.Series["X1"].Points.Clear();
            chartEniyi.Series["X2"].Points.Clear();
            chartFx.Series["Fx"].Points.Clear();

            Koloni yapayAriKolonisi = new Koloni(koloniBoyutu, altSinir, ustSinir, cevrimSayisi, denemeSayisi);

            dataGridView1.Rows.Clear(); 

            for (int i = 0; i < 25; i++)
            {
                chartEniyi.Series["X1"].Points.Add(yapayAriKolonisi.eniyiX1List[i]);
                chartEniyi.Series["X2"].Points.Add(yapayAriKolonisi.eniyiX2List[i]);
                chartFx.Series["Fx"].Points.Add(yapayAriKolonisi.fxDegerleri[i]);

                dataGridView1.Rows.Add(
                    yapayAriKolonisi.eniyiX1List[i],
                    yapayAriKolonisi.eniyiX2List[i],
                    yapayAriKolonisi.fxDegerleri[i],
                    yapayAriKolonisi.fitDegerleri[i]
                );
            }
            double enIyiFx = yapayAriKolonisi.fxDegerleri.Min();
            int enIyiIndex = yapayAriKolonisi.fxDegerleri.IndexOf(enIyiFx);

            double enIyiX1 = yapayAriKolonisi.eniyiX1List[enIyiIndex];
            double enIyiX2 = yapayAriKolonisi.eniyiX2List[enIyiIndex];

            lblEnIyiCozum.Text = $"En İyi Çözüm:  x1 = {enIyiX1:F4}, x2 = {enIyiX2:F4}";
            lblEnIyiFx.Text = $"Amaç Fonksiyonu (fx):  {enIyiFx:F4}";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Columns.Add("x1", "X1");
            dataGridView1.Columns.Add("x2", "X2");
            dataGridView1.Columns.Add("fx", "Fx");
            dataGridView1.Columns.Add("fit", "Fit");
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
