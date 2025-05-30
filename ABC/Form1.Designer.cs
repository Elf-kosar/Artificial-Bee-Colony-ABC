namespace ABC
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DenemeSayisi = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CevrimSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UstSinir = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.AltSinir = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.KoloniBoyutu = new System.Windows.Forms.NumericUpDown();
            this.chartFx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEniyi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEnIyiCozum = new System.Windows.Forms.Label();
            this.lblEnIyiFx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DenemeSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CevrimSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UstSinir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltSinir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoloniBoyutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEniyi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(848, 377);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "X1 ve X2 Grafiği";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(219, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Fx Grafiği";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(51, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Deneme Sayısı";
            // 
            // DenemeSayisi
            // 
            this.DenemeSayisi.Location = new System.Drawing.Point(184, 153);
            this.DenemeSayisi.Margin = new System.Windows.Forms.Padding(6);
            this.DenemeSayisi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DenemeSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DenemeSayisi.Name = "DenemeSayisi";
            this.DenemeSayisi.Size = new System.Drawing.Size(220, 22);
            this.DenemeSayisi.TabIndex = 30;
            this.DenemeSayisi.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(61, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Çevrim Sayısı";
            // 
            // CevrimSayisi
            // 
            this.CevrimSayisi.Location = new System.Drawing.Point(184, 189);
            this.CevrimSayisi.Margin = new System.Windows.Forms.Padding(6);
            this.CevrimSayisi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CevrimSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CevrimSayisi.Name = "CevrimSayisi";
            this.CevrimSayisi.Size = new System.Drawing.Size(220, 22);
            this.CevrimSayisi.TabIndex = 28;
            this.CevrimSayisi.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.RosyBrown;
            this.btnHesapla.Location = new System.Drawing.Point(268, 236);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(109, 46);
            this.btnHesapla.TabIndex = 27;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(94, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Üst Sınır";
            // 
            // UstSinir
            // 
            this.UstSinir.Location = new System.Drawing.Point(184, 119);
            this.UstSinir.Margin = new System.Windows.Forms.Padding(6);
            this.UstSinir.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UstSinir.Name = "UstSinir";
            this.UstSinir.Size = new System.Drawing.Size(220, 22);
            this.UstSinir.TabIndex = 25;
            this.UstSinir.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(99, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Alt Sınır";
            // 
            // AltSinir
            // 
            this.AltSinir.Location = new System.Drawing.Point(184, 85);
            this.AltSinir.Margin = new System.Windows.Forms.Padding(6);
            this.AltSinir.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AltSinir.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.AltSinir.Name = "AltSinir";
            this.AltSinir.Size = new System.Drawing.Size(220, 22);
            this.AltSinir.TabIndex = 23;
            this.AltSinir.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Koloni Boyutu";
            // 
            // KoloniBoyutu
            // 
            this.KoloniBoyutu.Location = new System.Drawing.Point(184, 52);
            this.KoloniBoyutu.Margin = new System.Windows.Forms.Padding(6);
            this.KoloniBoyutu.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KoloniBoyutu.Name = "KoloniBoyutu";
            this.KoloniBoyutu.Size = new System.Drawing.Size(220, 22);
            this.KoloniBoyutu.TabIndex = 21;
            this.KoloniBoyutu.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // chartFx
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFx.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFx.Legends.Add(legend5);
            this.chartFx.Location = new System.Drawing.Point(62, 407);
            this.chartFx.Name = "chartFx";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Fx";
            this.chartFx.Series.Add(series7);
            this.chartFx.Size = new System.Drawing.Size(466, 300);
            this.chartFx.TabIndex = 36;
            this.chartFx.Text = "chart1";
            // 
            // chartEniyi
            // 
            chartArea6.Name = "ChartArea1";
            this.chartEniyi.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartEniyi.Legends.Add(legend6);
            this.chartEniyi.Location = new System.Drawing.Point(690, 407);
            this.chartEniyi.Name = "chartEniyi";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "X1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "X2";
            this.chartEniyi.Series.Add(series8);
            this.chartEniyi.Series.Add(series9);
            this.chartEniyi.Size = new System.Drawing.Size(437, 300);
            this.chartEniyi.TabIndex = 37;
            this.chartEniyi.Text = "chart2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(543, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(534, 245);
            this.dataGridView1.TabIndex = 38;
            // 
            // lblEnIyiCozum
            // 
            this.lblEnIyiCozum.AutoSize = true;
            this.lblEnIyiCozum.BackColor = System.Drawing.Color.RosyBrown;
            this.lblEnIyiCozum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnIyiCozum.Location = new System.Drawing.Point(540, 304);
            this.lblEnIyiCozum.Name = "lblEnIyiCozum";
            this.lblEnIyiCozum.Size = new System.Drawing.Size(86, 16);
            this.lblEnIyiCozum.TabIndex = 39;
            this.lblEnIyiCozum.Text = "En İyi Çözüm:";
            // 
            // lblEnIyiFx
            // 
            this.lblEnIyiFx.AutoSize = true;
            this.lblEnIyiFx.BackColor = System.Drawing.Color.RosyBrown;
            this.lblEnIyiFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnIyiFx.Location = new System.Drawing.Point(540, 340);
            this.lblEnIyiFx.Name = "lblEnIyiFx";
            this.lblEnIyiFx.Size = new System.Drawing.Size(117, 16);
            this.lblEnIyiFx.TabIndex = 40;
            this.lblEnIyiFx.Text = "Amaç Fonksiyonu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 719);
            this.Controls.Add(this.lblEnIyiFx);
            this.Controls.Add(this.lblEnIyiCozum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chartEniyi);
            this.Controls.Add(this.chartFx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DenemeSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CevrimSayisi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UstSinir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AltSinir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KoloniBoyutu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DenemeSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CevrimSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UstSinir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltSinir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoloniBoyutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEniyi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DenemeSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CevrimSayisi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown UstSinir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AltSinir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown KoloniBoyutu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEniyi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEnIyiCozum;
        private System.Windows.Forms.Label lblEnIyiFx;
    }
}

