using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Common;
using System.Collections.Generic;
using ABC.BL;

namespace CommonTest
{
    [TestClass]
    public class LogServiceTest
    {
        [TestMethod]
        public void SaveToFileTest()
        {
            var changedElements = new List<ILog>();
            var client = new Klient(1)
            {
                Email = "mariusz@gmail.com",
                Imie = "Mariusz",
                Nazwisko = "Darian",
                AddressList = null
            };
            changedElements.Add(client as ILog);

            var product = new Product(1)
            {
                ProductName = "Rig",
                Description = "Rig do Simracingu",
                CurrentPrice = 400M
            };

            changedElements.Add(product as ILog);

            var order = new Order(1)
            {
                OrderDate = new DateTime(2021, 9, 21)

            };

            changedElements.Add(order as ILog);

            LogService.SaveToFile(changedElements);


        }
    }
}
