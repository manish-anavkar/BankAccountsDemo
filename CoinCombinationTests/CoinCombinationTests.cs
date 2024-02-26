using CoinCombination;

namespace CoinCombinationTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            // Amount can be made
            Assert.IsTrue(CoinsDemo.CanMakeAmount(2.20));
            Assert.IsTrue(CoinsDemo.CanMakeAmount(57.22));
            Assert.IsTrue(CoinsDemo.CanMakeAmount(32.27));
            Assert.IsTrue(CoinsDemo.CanMakeAmount(45.36));

            // Amount can't be made
            Assert.IsFalse(CoinsDemo.CanMakeAmount(0.01)); 
            Assert.IsFalse(CoinsDemo.CanMakeAmount(0.03));
            Assert.IsFalse(CoinsDemo.CanMakeAmount(0.02));
        }
    }
}