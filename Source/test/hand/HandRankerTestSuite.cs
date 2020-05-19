using wompa.source.rank;

namespace wompa.source.test.hand
{
    public class HandRankerTestSuite : ITest
    {
        public int Execute(ref int totalTests)
        {
            int passedTests = 0;
            HandRanker ranker = new HandRanker();

            passedTests += new HandRankerTest(ranker, "2H 4H 5H 7H JH", "2H 4H 5H 7H JH", 0).Execute(ref totalTests);
            passedTests += new HandRankerTest(ranker, "2H 2D 5H 7H JH", "2H 4D 5H 7H JH", 1).Execute(ref totalTests);
            passedTests += new HandRankerTest(ranker, "2H 2C 5H 7H JH", "2H 4C J 7H JH", 0).Execute(ref totalTests);
            passedTests += new HandRankerTest(ranker, "2D 4H 5H 7H JH", "2D 4H J 7H JH", -1).Execute(ref totalTests);
            
            passedTests += new HandRankerTest(ranker, "AH KH QH JH 10H", "2D 4D 5D 6D 7D", 1).Execute(ref totalTests);
            passedTests += new HandRankerTest(ranker, "KC QH JC 10H 9C", "2D 4D 5D 6D 7D", -1).Execute(ref totalTests);
            passedTests += new HandRankerTest(ranker, "AH AD AC 2H 2D", "6S 7S 8S 9S 10S", -1).Execute(ref totalTests);

            return passedTests;
        }
    }
}