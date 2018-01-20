using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{
    public abstract class Umowa
    {
        public double KwotaBrutto { get; set; }
        public double KwotaNetto { get; set; }
        public double Podatek { get; set; }
        public double SkladkaEmerytalna { get; set; }
        public double SkladkaRentowa { get; set; }
        public double SkladkaChorobowa { get; set; }
        public double Podstawa { get; set; }
        public double SkladkaZdrowotna { get; set; }
        public bool Tworca { get; set; }
        public double KosztPrzychodu { get; set; }
        private static double kwotaWolna = 46.33;
        protected static double KwotaWolna { get => kwotaWolna; set => kwotaWolna = value; }
    }
}
