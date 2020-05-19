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
// 
            // Straight
            passedTests += new HandProcessorTest("AH KH QH JH 10H", new StraightRankProcessor(), true).Execute(ref totalTests);
            passedTests += new HandProcessorTest("KH QC JH 10H J", new StraightRankProcessor(), true).Execute(ref totalTests);
            passedTests += new HandProcessorTest("KH QH JD 10H 9H", new StraightRankProcessor(), true).Execute(ref totalTests);
            
            // TODO: Test cases for wrap around ace straights do not pass currently.
            // passedTests += new HandProcessorTest("5H 4H 3H 2H AH", new StraightRankProcessor(), true).Execute(ref totalTests);
            // passedTests += new HandProcessorTest("5H 4H 3H 2H AH", new StraightRankProcessor(), true).Execute(ref totalTests);
            // passedTests += new HandProcessorTest("5H J 3H 2H AH", new StraightRankProcessor(), true).Execute(ref totalTests);
            // passedTests += new HandProcessorTest("5H 4H J J AH", new StraightRankProcessor(), true).Execute(ref totalTests);
            passedTests += new HandProcessorTest("KH QH JH 2H AH", new StraightRankProcessor(), false).Execute(ref totalTests);
            passedTests += new HandProcessorTest("5H KH 3H 2H AH", new StraightRankProcessor(), false).Execute(ref totalTests);
            passedTests += new HandProcessorTest("7H 4H J J AH", new StraightRankProcessor(), false).Execute(ref totalTests);
            
            // Royal Flush
            passedTests += new HandProcessorTest("AH KH QH JH 10H", new RoyalFlushRankProcessor(), true).Execute(ref totalTests);
            passedTests += new HandProcessorTest("KH QH JH 10H J", new RoyalFlushRankProcessor(), true).Execute(ref totalTests);
            passedTests += new HandProcessorTest("KH QH JH 10H 9H", new RoyalFlushRankProcessor(), false).Execute(ref totalTests);
            passedTests += new HandProcessorTest("KH QH JH 10H AD", new RoyalFlushRankProcessor(), false).Execute(ref totalTests);
            
            // Three of a Kind
            passedTests += new HandProcessorTest("AH KH QH JH 10H", new NofaKindRankProcessor(3), false).Execute(ref totalTests);
            passedTests += new HandProcessorTest("JC QH JH 10H JD", new NofaKindRankProcessor(3), true).Execute(ref totalTests);
            passedTests += new HandProcessorTest("4H 6D J J KC", new NofaKindRankProcessor(3), true).Execute(ref totalTests);
            
            
            return passedTests;
        }
    }
}