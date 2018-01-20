using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClass;

namespace CalculatorTest
{
    [TestClass]
    public class UmowaZlecenieTest
    {
        [TestMethod]
        public void UmowaZlecenieKwotaBruttoTest()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            Assert.AreEqual(5000, umowaZlecenie.KwotaBrutto);
        }

        [TestMethod]
        public void UmowaZlecenieKwotaNettoTest()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(3639.2, umowaZlecenie.KwotaNetto);
        }

        [TestMethod]
        public void UmowaZlecenieSkladkaEmerytalnaTest()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(488.00, System.Math.Round(umowaZlecenie.SkladkaEmerytalna,0));
        }

        [TestMethod]
        public void UmowaZlecenieSkladkaRentowaTest()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(75, umowaZlecenie.SkladkaRentowa);
        }
        
        [TestMethod]
        public void UmowaZlecenieSkladkaChorobowaTest()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(122.5, umowaZlecenie.SkladkaChorobowa);
        }

        [TestMethod]
        public void UmowaZleceniePodstawaTest()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(4314.5, umowaZlecenie.Podstawa);
        }

        [TestMethod]
        public void UmowaZlecenieSkladkaZdrowotnaTest()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(388.3, umowaZlecenie.SkladkaZdrowotna);

        }

        [TestMethod]
        public void UmowaZleceniePodatekTest()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(287, umowaZlecenie.Podatek);
        }

        [TestMethod]
        public void UmowaZlecenieObliczSkladkeZdrowotna7_75Test()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(334.37, umowaZlecenie.ObliczSkladkeZdrowotna(7.75));
        }

        [TestMethod]
        public void UmowaZlecenieObliczSkladkeZdrowotna9Test()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(388.3, umowaZlecenie.ObliczSkladkeZdrowotna(9));
        }

        [TestMethod]
        public void UmowaZlecenieObliczPodstaweTest()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(4314.5, umowaZlecenie.ObliczPodstawe());
        }

        [TestMethod]
        public void UmowaZleceniePodstawaZaliczkiTest()
        {
            UmowaZlecenie umowaZlecenie = new UmowaZlecenie(5000, false);
            umowaZlecenie.Oblicz();
            Assert.AreEqual(3452, umowaZlecenie.ObliczKwoteOpodatkowana());
        }
    }
}
