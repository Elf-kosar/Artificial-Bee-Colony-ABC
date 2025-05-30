using System;

namespace ABC
{
    internal class Besin
    {
        private Besinler[] besinler;
        int yemekKaynak;
        int altSinir;
        int ustSinir;

        public Besin(int yemekKaynak, int altSinir, int ustSinir)
        {
            this.yemekKaynak = yemekKaynak;
            this.altSinir = altSinir;
            this.ustSinir = ustSinir;
            Besinler = new Besinler[yemekKaynak];

        }

        internal Besinler[] Besinler { get => besinler; set => besinler = value; }

        public void besinOlustur()
        {
            for (int i = 0; i < yemekKaynak; i++)
            {
                Besinler[i] = new Besinler(altSinir, ustSinir);
            }
        }

    
        public Besinler enKaliteliYemek()
        {
            Besinler enKaliteli = Besinler[0];
            for (int i = 1; i < Besinler.Length; i++)
            {
                if (enKaliteli.fit < Besinler[i].fit)
                {
                    enKaliteli = Besinler[i];
                }
            }
            return enKaliteli;
        }

        public void isciAriOlasilik()
        {
            ABC.Besinler.olasiklikDegerleriVer(Besinler);
        }
    }
}
