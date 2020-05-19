using wompa.source.rank.processor;
using wompa.source.test.hand.processor;

namespace wompa.source.test.hand
{
    public class HandProcessorTestSuite : ITest
    {
        public int Execute(ref int totalTests)
        {
            int passedTests = 0;

            // Flush
            passedTests += new HandProcessorTest("2H 4H 5H 7H JH", new FlushRankProcessor(), true).Execute(ref totalTests);
            passedTests += new HandProcessorTest("J 4H 5H 7H JH", new FlushRankProcessor(), true).Execute(ref totalTests);
            passedTests += new HandProcessorTest("2H 4H 5H J JD", new FlushRankProcessor(), false).Execute(ref totalTests);
            passedTests += new HandProcessorTest("J J J J J", new FlushRankProcessor(), true).Execute(ref totalTests);
            passedTests += new HandProcessorTest("J 4H J KD J", new FlushRankProcessor(), false).Execute(ref totalTests);
            
            return passedTests;
        }
    }
}