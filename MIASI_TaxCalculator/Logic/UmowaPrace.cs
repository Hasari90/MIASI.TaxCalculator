namespace CalculatorClass
{
    public class UmowaPrace : Umowa
    {
        public UmowaPrace(double kwota, bool tworca)
        {
            KwotaBrutto = kwota;
            Tworca = tworca;
        }

        public void Oblicz()
        {
            SkladkaEmerytalna = ObliczSkladke(9.76);
            SkladkaRentowa = ObliczSkladke(1.5);
            SkladkaChorobowa = ObliczSkladke(2.45);
            Podstawa = ObliczPodstawe();
            SkladkaZdrowotna = ObliczSkladkeZdrowotna(9);
            Podatek = ObliczPodatek();
            KwotaNetto = ObliczKwoteNetto();
        }

        public double ObliczSkladke(double procent) => KwotaBrutto * (procent/100);
        public double ObliczPodstawe() => KwotaBrutto - (SkladkaEmerytalna + SkladkaRentowa + SkladkaChorobowa);
        public double ObliczSkladkeZdrowotna(double procent) => System.Math.Round(ObliczPodstawe() * (procent/100),2);
        public double ObliczKwoteOpodatkowana() => System.Math.Round(ObliczPodstawe() - (Tworca ? (ObliczPodstawe() * 0.5) : (111.25)));
        public double ObliczPodatek() => System.Math.Round((ObliczKwoteOpodatkowana() * 0.18) - ObliczSkladkeZdrowotna(7.75) - KwotaWolna,0);
        public double ObliczKwoteNetto() => ObliczPodstawe() - (SkladkaZdrowotna + Podatek);

    }
}