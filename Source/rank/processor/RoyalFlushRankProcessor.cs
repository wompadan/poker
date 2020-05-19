using wompa.source.card;

namespace wompa.source.rank.processor
{
    public class RoyalFlushRankProcessor : IRankProcessor
    {
        public bool Match(CardEntity[] hand)
        {
            bool flush = new FlushRankProcessor().Match(hand);
            bool straight = new StraightRankProcessor().Match(hand);
            bool aceHigh = hand[0].ValueProp.Compare(14);
            return flush && straight && aceHigh;
        }
    }
}