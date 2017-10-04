using NUnit.Framework;

namespace Demo
{
    [TestFixture]
    public class SimpleTest
    {
        [Test]
        public void JustChecking()
        {
            Assert.That(true);
        }

        [TestCase(42, 1)]
        public void JustCheckingParameters(int number, int limit)
        {
            Assert.That(number,Is.GreaterThan(limit));
        }
    }
}
