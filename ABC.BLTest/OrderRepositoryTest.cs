using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }
}
