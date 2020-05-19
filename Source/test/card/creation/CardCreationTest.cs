using System;
using wompa.source.card;
using wompa.source.core;

namespace wompa.source.test.card.creation
{
    public class CardCreationTest : ITest
    {
        private CardEntity _card;
        private Suit _testSuit;
        private int _testValue;
        
        public CardCreationTest(string desc, Suit testSuit, int testValue)
        {
            _card = CardFactory.GenerateCard(desc);
            _testSuit = testSuit;
            _testValue = testValue;
        }
        
        public int Execute(ref int totalTests)
        {
            totalTests += 1;

            if (_card == null)
            {
                Console.WriteLine("Card Not Created"); 
                return 0;
            }
            if (_card.SuitProp == null)
            {
                Console.WriteLine("Card SuitProp Not Created"); 
                return 0;
            }
            if (_card.ValueProp == null)
            {
                Console.WriteLine("Card ValueProp Not Created"); 
                return 0;
            }
            if (!_card.SuitProp.Compare(_testSuit))
            {
                Console.WriteLine("Card Suit Not Correct"); 
                return 0;
            }
            if (!_card.ValueProp.Compare(_testValue))
            {
                Console.WriteLine("Card Value Not Correct"); 
                return 0;
            }

            return 1;
        }
    }
}