using _1_TypyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TypyGeneryczne_Test
{
    [TestClass]
    public class KolejkaKolowa_TEST
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa<double>();
            Assert.IsTrue(kolejka.JestPusty);
        }
        [TestMethod]
        public void KolejkaTrzyelementowaJestPelnaPoTrzechZapisach()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            kolejka.Zapisz(3.6);
            kolejka.Zapisz(1.2);
            kolejka.Zapisz(11);
            Assert.IsTrue(kolejka.JestPelny);
        }
        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            var kolejka = new KolejkaKolowa<string>(pojemnosc: 3);
            var wartosc1 = "4.6";
            var wartosc2 = "3.7";

            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, kolejka.Czytaj());
            Assert.AreEqual(wartosc2, kolejka.Czytaj());

            Assert.IsTrue(kolejka.JestPusty);
        }
        [TestMethod]
        public void NadpisujeGdyJestWiekszaNizPojemnosc()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            var wartosci = new[] { 1.2, 2.4, 3.6, 4.8, 3, 2};
            foreach(var wartosc in wartosci)
            {
                kolejka.Zapisz(wartosc);
            }
            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosci[3], kolejka.Czytaj());
            Assert.AreEqual(wartosci[4], kolejka.Czytaj());
            Assert.AreEqual(wartosci[5], kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }
    }
}
