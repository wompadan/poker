using wompa.source.core;
using wompa.source.test.card.creation;

namespace wompa.source.test.card
{
    public class CardCreationTestSuite : ITest
    {
        public int Execute(ref int totalTests)
        {
            int passedTests = 0;
            passedTests += new CardCreationTest("3H", Suit.Hearts, 3).Execute(ref totalTests);
            passedTests += new CardCreationTest("7D", Suit.Diamonds, 7).Execute(ref totalTests);
            passedTests += new CardCreationTest("AC", Suit.Clubs, 1).Execute(ref totalTests);
            passedTests += new CardCreationTest("AC", Suit.Clubs, 14).Execute(ref totalTests);
            passedTests += new CardCreationTest("JS", Suit.Spades, 11).Execute(ref totalTests);
            passedTests += new CardCreationTest("J", Suit.Hearts, 3).Execute(ref totalTests);
            passedTests += new CardCreationTest("J", Suit.Clubs, 5).Execute(ref totalTests);
            passedTests += new CardCreationTest("J", Suit.Diamonds, 14).Execute(ref totalTests);
            
            return passedTests;
        }
    }
}