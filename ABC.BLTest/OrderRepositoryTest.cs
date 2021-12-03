using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ABC.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void LoadOrderTest()
        {
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))

        };

            var actual = orderRepository.Load(1);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            Assert.AreEqual(expected.OrderId, actual.OrderId);
        }

        [TestMethod]
        public void LoadViewOrderTest()
        {
            var orderRepository = new OrderRepository();
            var expected = new OrderViewcs()
            {
                Name = "Dariusz",
                Surname = "Mariusz",
                OrderDate = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                DeliveryAddress = new Address()
                {
                    AddressType = 1,
                    Street = "happystreet",
                    City = "New York",
                    PostalCode = "00-000",
                    Country = "USA"
                },
                OrderPositionViewList = new List<OrderPositionView>()
                {
                new OrderPositionView()
                {
                    ProductName = "Rig",
                    OrderQuantity = 1,
                    PurchasePrice = 119M
                },
                new OrderPositionView()
                {
                    ProductName = "Screen",
                    OrderQuantity = 3,
                    PurchasePrice = 1200.99M
                }

                }
        };  

            var actual = orderRepository.LoadOrderToDisplay(10);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.DeliveryAddress.AddressType, actual.DeliveryAddress.AddressType);
            Assert.AreEqual(expected.DeliveryAddress.Street, actual.DeliveryAddress.Street);
            Assert.AreEqual(expected.DeliveryAddress.City, actual.DeliveryAddress.City);
            Assert.AreEqual(expected.DeliveryAddress.PostalCode, actual.DeliveryAddress.PostalCode);
            Assert.AreEqual(expected.DeliveryAddress.Country, actual.DeliveryAddress.Country);

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected.OrderPositionViewList[i].ProductName, actual.OrderPositionViewList[i].ProductName);
                Assert.AreEqual(expected.OrderPositionViewList[i].OrderQuantity, actual.OrderPositionViewList[i].OrderQuantity);
                Assert.AreEqual(expected.OrderPositionViewList[i].PurchasePrice, actual.OrderPositionViewList[i].PurchasePrice);
            }
        }
    }
}
