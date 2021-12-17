using NUnit.Framework;

namespace Sample
{
    public class SampleTest
    {
        [Test]
        public void CalcTest()
        {
            Assert.AreEqual(1 + 1, 2, "must be same");
        }
    }
}