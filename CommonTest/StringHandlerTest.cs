using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void SpaceInsertTest()
        {
            string source = "GamingowySimracingowyRig";
            string expected = "Gamingowy Simracingowy Rig";

            var actual = StringHandler.SpaceInsert(source);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SpaceInsertTestWithSpace()
        {
            string source = "Gamingowy SimracingowyRig";
            string expected = "Gamingowy Simracingowy Rig";

            var actual = StringHandler.SpaceInsert(source);

            Assert.AreEqual(expected, actual);

        }
    }
}
