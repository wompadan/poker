using wompa.source.core;

namespace wompa.source.card
{
    public class WildSuitProp : ISuitProp
    {
        public bool Compare(Suit testValue)
        {
            return true;
        }

        public bool IsWild()
        {
            return true;
        }

        public Suit GetMatchingSuit()
        {
            return Suit.Invalid;
        }
    }
}