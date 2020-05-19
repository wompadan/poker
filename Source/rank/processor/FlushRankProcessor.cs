using wompa.source.card;
using wompa.source.core;

namespace wompa.source.rank.processor
{
    public class FlushRankProcessor : IRankProcessor
    {
        public bool Match(CardEntity[] hand)
        {
            Suit firstNonWildSuit = Suit.Invalid;
            for (int i = 0; i < hand.Length; ++i)
            {
                // All wilds make a flush
                if (hand[i].SuitProp.IsWild()) continue;
                
                // First non wild defines our test suit
                if (firstNonWildSuit == Suit.Invalid)
                {
                    firstNonWildSuit = hand[i].SuitProp.GetMatchingSuit();
                    continue;
                }

                // Subsequent cards must match the first non wild
                if (hand[i].SuitProp.Compare(firstNonWildSuit)) continue;

                // If any card reaches this point, the flush is broken
                return false;
            }

            // Otherwise all cards are valid for a flush
            return true;
        }
    }
}