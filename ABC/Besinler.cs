using System;

namespace ABC
{
    internal class Besinler
    {
        public double x1;
        public double x2;
        public double fx;
        public double fit;

        public double olasilikDegeri;

        public int iyilestirilememe = 0;
        public static readonly Object kilitlemeNesnesi = new Object();
        public static readonly Random rnd = new Random();

        public Besinler(int altSinir, int ustSinir)
        {
            x1 = GetRandomNumber(altSinir, ustSinir);
            x2 = GetRandomNumber(altSinir, ustSinir);
            fx = fonksiyonDegeri(x1, x2);
            fit = fitFonksiyonu(fx);
        }

        public double fonksiyonDegeri(double x1, double x2)
        {
            return Math.Pow(x1, 2) + Math.Pow(x2, 2);
        }

        public double fitFonksiyonu(double fx)
        {
            if (fx >= 0)
            {
                return 1 / (1 + fx);
            }
            else
            {
                return 1 + Math.Abs(fx);
            }
        }

        public static void olasiklikDegerleriVer(Besinler[] besinler)
        {
            double toplamFit = 0;

            for (int i = 0; i < besinler.Length; i++)
            {
                toplamFit += besinler[i].fit; 
            }

            for (int i = 0; i < besinler.Length; i++)
            {
                besinler[i].olasilikDegeri = besinler[i].fit / toplamFit;
            }
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
