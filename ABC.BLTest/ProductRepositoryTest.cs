using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ABC.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void LoadProductTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "rig",
                Description = "rig dla simracera",
                CurrentPrice = 1990.89M,
            };

            var actual = productRepository.Load(1);

          
            Assert.AreEqual(expected.ProduktId, actual.ProduktId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}
