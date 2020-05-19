using System;
using wompa.source.card;
using wompa.source.rank.processor;

namespace wompa.source.test.hand.processor
{
    public class HandProcessorTest : ITest
    {
        private string _desc;
        private IRankProcessor _processor;
        private bool _result;
        
        public HandProcessorTest(string desc, IRankProcessor processor, bool result)
        {
            _desc = desc;
            _processor = processor;
            _result = result;
        }

        public int Execute(ref int totalTests)
        {
            totalTests++;
            
            CardEntity[] hand = CardFactory.GenerateHand(_desc);
            bool actualResult = _processor.Match(hand);

            if (_result != actualResult)
            {
                Console.WriteLine($"{_desc} did not result in a match for {_processor.GetType().ToString()}");
                return 0;
            }
            
            return 1;

        }
    }
}