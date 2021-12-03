using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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

        [TestMethod]
        public void LoadKlientWithAddresses()
        {
            var klientRepository = new KlientRepository();
            var expected = new Klient(1)
            {
                Email = "dariusz@gmail.com",
                Imie = "Dariusz",
                Nazwisko = "Mariusz",
                AddressList = new List<Address>()
                {
                    new Address(1)
                    {
                        AddressType = 1,
                        Street = "Happy Place",
                         City = "New York",
                        Country = "USA",
                        PostalCode = "00-000",
                    },
                    new Address(2)
                    {
                        AddressType = 2,
                        Street = "Unhappy Place",
                        City = "New York",
                        Country = "USA",
                        PostalCode = "00-000",
                    }

        }
            };

            var actual = klientRepository.Load(1);

            // Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.KlientId, actual.KlientId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.Imie, actual.Imie);
            Assert.AreEqual(expected.Nazwisko, actual.Nazwisko);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].Street, actual.AddressList[i].Street);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }

        }
    }
}
