using NUnit.Framework;
using wompa.source;

namespace wompa_tests
{
    [TestFixture]
    public class CardCreation_Tests
    {
        [Test]
        public void CreateStandardCard()
        {
            Assert.Null(CardFactory.GenerateCard(string.Empty));
        }
    }
}