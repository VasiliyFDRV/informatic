using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task11;
using NUnit.Framework;

namespace Task11UnitTests
{
    [TestFixture]
    class UnitTests
    {
        private List<string> testPlan = new List<string> { "Venice", "Milan", "Rome" };    

        [Test]
        public void ConstructorTest()
        {
            var tour = CreateTestTour();

            Assert.AreEqual("Italy tour", tour.Name);
            Assert.AreEqual(42069,tour.Code);
            Assert.AreEqual(testPlan,tour.Plan);
            Assert.AreEqual(TransportType.train, tour.Transport);
            Assert.AreEqual(21, tour.Duration);
        }

        [Test]
        public void ToString_Tour_NameSpaceCode()
        {
            var tour = CreateTestTour();
            Assert.AreEqual("Italy tour 42069", tour.ToString());
        }

        private Tour CreateTestTour()
        {
            return new Tour("Italy tour", 42069, testPlan, TransportType.train, 21);
        }
    }
}
