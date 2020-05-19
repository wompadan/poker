using wompa.source.core;

namespace wompa.source.card
{
    public class StandardSuitProp : ISuitProp
    {
        private Suit _suit;
        public StandardSuitProp(Suit suit)
        {
            _suit = suit;
        }
        
        public bool Compare(Suit testValue)
        {
            return testValue == _suit;
        }

        public bool IsWild()
        {
            return false;
        }

        public Suit GetMatchingSuit()
        {
            return _suit;
        }
    }
}