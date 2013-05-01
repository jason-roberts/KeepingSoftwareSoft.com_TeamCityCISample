using System.Threading;
using NUnit.Framework;

namespace Calculator.IntegrationTests
{
    [TestFixture]
    public class SomePretendIntegrationTests
    {
        private void SimulateLongTest()
        {
            Thread.Sleep(5000);
        }

        [Test]
        public void Test1()
        {
            SimulateLongTest();
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            SimulateLongTest();
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            SimulateLongTest();
            Assert.Pass();
        }

        [Test]
        [Category("smoke")]
        public void Test4()
        {
            SimulateLongTest();
            Assert.Pass();
        }

        [Test]
        [Category("smoke")]
        public void Test5()
        {
            SimulateLongTest();
            Assert.Pass();
        }
    }
}