using System;
using wompa.source.test.card;
using wompa.source.test.hand;

namespace wompa.source.test
{
    public class TestRunner
    {
        public static void RunTests()
        {
            int passedTests = 0;
            int totalTests = 0;
            passedTests += new CardCreationTestSuite().Execute(ref totalTests);
            passedTests += new HandProcessorTestSuite().Execute(ref totalTests);
            passedTests += new HandSortTestSuite().Execute(ref totalTests);
            passedTests += new HandRankerTestSuite().Execute(ref totalTests);

            Console.WriteLine($"{passedTests} out of {totalTests} tests passed.");
        }
    }
}