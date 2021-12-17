using NUnit.Framework;

namespace Sample
{
    public class SampleTest
    {
        [Test]
        public void ParseTest()
        {
            Assert.AreEqual(1 + 1, 1, "must be same");
        }
    }
}