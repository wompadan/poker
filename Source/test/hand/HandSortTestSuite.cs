namespace wompa.source.test.hand
{
    public class HandSortTestSuite : ITest
    {
        public int Execute(ref int totalTests)
        {
            int passedTests = 0;

            // Flush
            passedTests += new HandSortTest("2H 4H 5H 7H JH", true).Execute(ref totalTests);
            passedTests += new HandSortTest("JH 2H 4H 5H 7H", true).Execute(ref totalTests);
            passedTests += new HandSortTest("JH 2H J 5H 7H", true).Execute(ref totalTests);
            passedTests += new HandSortTest("J J J J J", true).Execute(ref totalTests);
            
            return passedTests;
        }
    }
}