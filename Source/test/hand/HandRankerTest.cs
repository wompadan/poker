using System;
using wompa.source.card;
using wompa.source.rank;

namespace wompa.source.test.hand
{
    public class HandRankerTest : ITest
    {
        private string _a;
        private string _b;
        private int _result;
        private HandRanker _ranker;
        
        public HandRankerTest(HandRanker ranker, string a, string b, int result)
        {
            _ranker = ranker;
            _a = a;
            _b = b;
            _result = result;
        }
        
        public int Execute(ref int totalTests)
        {
            totalTests += 1;

            CardEntity[] handA = CardFactory.GenerateHand(_a);
            CardEntity[] handB = CardFactory.GenerateHand(_b);
            int actualResult = _ranker.CompareHands(handA, handB);

            if (actualResult != _result)
            {
                Console.WriteLine($"{_a} vs {_b} should result in {_result}, not {actualResult}.");
                Console.WriteLine($"A: {_ranker.GetScore(handA)} vs B: {_ranker.GetScore(handB)}");
                return 0;
            }

            return 1;
        }
    }
}