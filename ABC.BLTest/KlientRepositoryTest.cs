using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void LoadKlient()
        {
            var klientRepository = new KlientRepository();
            var expected = new Klient(1)
            {
                Email = "dariusz@gmail.com",
                Imie = "Dariusz",
                Nazwisko = "Mariusz"
            };

            var actual = klientRepository.Load(1);

            // Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.KlientId, actual.KlientId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.Imie, actual.Imie);
            Assert.AreEqual(expected.Nazwisko, actual.Nazwisko);

        }
    }
}
