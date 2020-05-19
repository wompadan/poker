using System;
using System.Text;
using wompa.source.card;

namespace wompa.source.test.hand
{
    public class HandSortTest : ITest
    {
        private string _desc;
        private bool _result;
        
        public HandSortTest(string desc, bool result)
        {
            _desc = desc;
            _result = result;
        }
        
        public int Execute(ref int totalTests)
        {
            totalTests += 1;
            
            CardEntity[] hand = CardFactory.GenerateHand(_desc);
            StringBuilder sb = new StringBuilder();
            int lastValue = 14;
            bool goodSort = true;
            for (int i = 0; i < 5; ++i)
            {
                sb.Append(string.Format(hand[i].ValueProp.GetNameFormat(),
                    hand[i].SuitProp.GetMatchingSuit().ToString()));
                sb.Append(" ");
                if (hand[i].ValueProp.GetHighestValue() > lastValue) goodSort = false;
                lastValue = hand[i].ValueProp.GetHighestValue();
            }

            if (goodSort != _result)
            {
                Console.WriteLine($"{sb.ToString()}did not sort as expected");
                return 0;
            }

            return 1;
        }
    }
}