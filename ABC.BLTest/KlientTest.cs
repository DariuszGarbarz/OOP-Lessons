﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ABC.BL;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Nowak, Tomasz";

            string aktualna = klient.ImieNazwisko;

            Assert.AreEqual(oczekiwana, aktualna);
        }
       
        [TestMethod]
        public void ImieNazwiskoImiePusteTest()
        {
            Klient klient = new Klient();
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Nowak";

            string aktualna = klient.ImieNazwisko;

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImieNazwiskoNazwiskoPusteTest()
        {
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            string oczekiwana = "Tomasz";

            string aktualna = klient.ImieNazwisko;

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void StaticTest()
        {
            Klient klient1 = new Klient();
            klient1.Imie = "Tomasz";
            Klient.Counter += 1;

            Klient klient2 = new Klient();
            klient2.Imie = "Maciek";
            Klient.Counter += 1;

            Klient klient3 = new Klient();
            klient3.Imie = "Domino";
            Klient.Counter += 1;

            Assert.AreEqual(3, Klient.Counter);
        }

        [TestMethod]
        public void ValidateCorrectTest()
        {
            Klient klient1 = new Klient();
            klient1.Imie = "Tomasz";
            klient1.Email = "tomasz@gmail.com";
            klient1.Nazwisko = "Nowak";
            var expected = true;

            bool actual = klient1.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateUncorrectEmailTest()
        {
            Klient klient1 = new Klient();
            klient1.Imie = "Tomasz";
            klient1.Nazwisko = "Nowak";
            var expected = false;

            bool actual = klient1.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateUncorrectNazwiskoTest()
        {
            Klient klient1 = new Klient();
            klient1.Imie = "Tomasz";
            klient1.Email = "tomasz@gmail.com";
            var expected = false;

            //var klient2 = new Klient(100);
            //var klient3 = new Klient();

            bool actual = klient1.Validate();

            Assert.AreEqual(expected, actual);
        }


    }
}
