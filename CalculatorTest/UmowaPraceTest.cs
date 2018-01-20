using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClass;

namespace CalculatorTest
{
    [TestClass]
    public class UmowaPraceTest
    {
        [TestMethod]
        public void UmowaPraceKwotaBruttoTest()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            Assert.AreEqual(5000, umowaPrace.KwotaBrutto);
        }

        [TestMethod]
        public void UmowaPraceKwotaNettoTest()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(3550.2, umowaPrace.KwotaNetto);
        }

        [TestMethod]
        public void UmowaPraceSkladkaEmerytalnaTest()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(488.00, System.Math.Round(umowaPrace.SkladkaEmerytalna,0));
        }

        [TestMethod]
        public void UmowaPraceSkladkaRentowaTest()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(75, umowaPrace.SkladkaRentowa);
        }
        
        [TestMethod]
        public void UmowaPraceSkladkaChorobowaTest()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(122.5, umowaPrace.SkladkaChorobowa);
        }

        [TestMethod]
        public void UmowaPracePodstawaTest()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(4314.5, umowaPrace.Podstawa);
        }

        [TestMethod]
        public void UmowaPraceSkladkaZdrowotnaTest()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(388.3, umowaPrace.SkladkaZdrowotna);

        }

        [TestMethod]
        public void UmowaPracePodatekTest()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(376, umowaPrace.Podatek);
        }

        [TestMethod]
        public void UmowaPraceObliczSkladkeZdrowotna7_75Test()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(334.37, umowaPrace.ObliczSkladkeZdrowotna(7.75));
        }

        [TestMethod]
        public void UmowaPraceObliczSkladkeZdrowotna9Test()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(388.3, umowaPrace.ObliczSkladkeZdrowotna(9));
        }

        [TestMethod]
        public void UmowaPraceObliczPodstaweTest()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(4314.5, umowaPrace.ObliczPodstawe());
        }

        [TestMethod]
        public void UmowaPracePodstawaZaliczkiTest()
        {
            UmowaPrace umowaPrace = new UmowaPrace(5000, false);
            umowaPrace.Oblicz();
            Assert.AreEqual(4203, umowaPrace.ObliczKwoteOpodatkowana());
        }
    }
}
