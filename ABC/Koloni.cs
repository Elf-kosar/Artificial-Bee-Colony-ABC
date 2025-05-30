using System;
using System.Collections.Generic;

namespace ABC
{
    internal class Koloni
    {
        int koloniBoyutu;
        int altSinir;
        int ustSinir;
        int cevrimSayisi;
        int yemekKaynak;
        int denemeSayisi;

        int isciAri;
        int gozcuAri;

        public Besin besin;

        public double eniyiX1;
        public double eniyiX2;

        public List<double> fxDegerleri = new List<double>();

        public List<double> fitDegerleri = new List<double>();

        public List<double> eniyiX1List = new List<double>();
        public List<double> eniyiX2List = new List<double>();

        public static readonly Object kilitlemeNesnesi = new Object();
        public static readonly Random rnd = new Random();




        public Koloni(int koloniBoyutu, int altSinir, int ustSinir, int cevrimSayisi, int denemeSayisi)
        {
            this.koloniBoyutu = koloniBoyutu;

            this.yemekKaynak = koloniBoyutu / 2;
            this.isciAri = koloniBoyutu / 2; 
            this.gozcuAri = koloniBoyutu / 2; 

            this.altSinir = altSinir;
            this.ustSinir = ustSinir;
            this.cevrimSayisi = cevrimSayisi;
            this.denemeSayisi = denemeSayisi;

            besin = new Besin(yemekKaynak, altSinir, ustSinir);

            besin.besinOlustur();

            for (int i = 0; i < cevrimSayisi; i++)
            {
                isciAriFazi();

                isciAriOlasiliklariTanimla();

                gozcuAriFazi();

                for (int j = 0; j < yemekKaynak; j++)
                {
                    if (besin.Besinler[j].iyilestirilememe > denemeSayisi)
                    {
                        besin.Besinler[j] = new Besinler(altSinir, ustSinir);
                    }
                }

                eniyiYemek();
            }

        }

        void isciAriFazi()
        {
            for (int i = 0; i < yemekKaynak; i++)
            {
                int k = (int)GetRandomNumber(0, yemekKaynak);
                int j = (int)GetRandomNumber(0, 2);
                double fi = GetRandomNumber(-1, 1);

                double x = 0;
                double xDiger = 0;

                if (j == 0)
                {
                    x = besin.Besinler[i].x1;
                }
                else
                {
                    x = besin.Besinler[i].x2;
                }

                if (j == 0)
                {
                    xDiger = besin.Besinler[k].x1;
                }
                else
                {
                    xDiger = besin.Besinler[k].x2;
                }

                double sonuc = 0;


                double yeniSonucX = x + fi;
                yeniSonucX = fitFonksiyonu(yeniSonucX);

                double yeniSonucX2 = x - xDiger;
                yeniSonucX2 = fitFonksiyonu(yeniSonucX2);

                sonuc = fitFonksiyonu(amacFonksiyonu(yeniSonucX, yeniSonucX2));

                if (sonuc > ustSinir)
                {
                    sonuc = ustSinir;
                }
                else if (sonuc < altSinir)
                {
                    sonuc = altSinir;
                }

                if (sonuc < besin.Besinler[i].fit)
                {
                    besin.Besinler[i].iyilestirilememe += 1;
                }
                else
                {
                    besin.Besinler[k].x1 = yeniSonucX;
                    besin.Besinler[k].x2 = yeniSonucX2;
                    besin.Besinler[k].fx = amacFonksiyonu(yeniSonucX, yeniSonucX2);
                    besin.Besinler[k].fit = sonuc;
                }
            }
        }

        public void gozcuAriFazi()
        {
            Random rnd = new Random();
            double randomDeger = 0;
            lock (kilitlemeNesnesi)
            {
                randomDeger = rnd.Next();
            }
            for (int i = 0; i < yemekKaynak; i++)
            {
                if (besin.Besinler[i].olasilikDegeri > randomDeger)
                {
                    gozcuAriHesapla(i);
                }
            }
        }

        public void gozcuAriHesapla(int i)
        {

            Random rnd = new Random();

            int k = (int)GetRandomNumber(0, yemekKaynak);
            int j = (int)GetRandomNumber(0, 2);
            double fi = (int)GetRandomNumber(-1, 1);

            double x = 0;
            double xDiger = 0;

            if (j == 0)
            {
                x = besin.Besinler[i].x1;
            }
            else
            {
                x = besin.Besinler[i].x2;
            }

            if (j == 0)
            {
                xDiger = besin.Besinler[k].x1;
            }
            else
            {
                xDiger = besin.Besinler[k].x2;
            }

            double sonuc = 0;


            double yeniSonucX = x + fi;
            yeniSonucX = fitFonksiyonu(yeniSonucX);

            double yeniSonucX2 = x - xDiger;
            yeniSonucX2 = fitFonksiyonu(yeniSonucX2);

            sonuc = fitFonksiyonu(amacFonksiyonu(yeniSonucX, yeniSonucX2));

            if (sonuc > ustSinir)
            {
                sonuc = ustSinir;
            }
            else if (sonuc < altSinir)
            {
                sonuc = altSinir;
            }


            if (sonuc < besin.Besinler[i].fit)
            {
                besin.Besinler[i].iyilestirilememe += 1;
            }
            else
            {
                besin.Besinler[k].x1 = yeniSonucX;
                besin.Besinler[k].x2 = yeniSonucX2;
                besin.Besinler[k].fx = amacFonksiyonu(yeniSonucX, yeniSonucX2);
                besin.Besinler[k].fit = sonuc;
            }

        }

        public void isciAriOlasiliklariTanimla()
        {
            besin.isciAriOlasilik();
        }

        public double amacFonksiyonu(double x1, double x2)
        {
            return Math.Pow(x1, 2) + Math.Pow(x2, 2);
        }

        public double fitFonksiyonu(double fi)
        {
            if (fi >= 0)
            {
                return 1 / (1 + fi);
            }
            else
            {
                return 1 + Math.Abs(fi);
            }
        }

        public double fitDegerleriToplam()
        {
            double toplam = 0;
            for (int i = 0; i < besin.Besinler.Length; i++)
            {
                toplam += besin.Besinler[i].fit;
            }
            return toplam;
        }

        public void eniyiYemek()
        {
            Besinler enKaliteli = besin.enKaliteliYemek();
            eniyiX1 = enKaliteli.x1;
            eniyiX2 = enKaliteli.x2;
            eniyiX1List.Add(eniyiX1);
            eniyiX2List.Add(eniyiX2);
            fxDegerleri.Add(enKaliteli.fx);
            fitDegerleri.Add(enKaliteli.fit);
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            lock (kilitlemeNesnesi)
            {
                return rnd.NextDouble() * (maximum - minimum) + minimum;
            }
        }
    }
}
