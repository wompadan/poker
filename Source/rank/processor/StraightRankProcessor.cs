using wompa.source.card;

namespace wompa.source.rank.processor
{
    public class StraightRankProcessor : IRankProcessor
    {
        public bool Match(CardEntity[] hand)
        {
            int jokerCount = hand[0].SuitProp.IsWild() ? 1 : 0;

            for (int i = 1; i < 5; ++i)
            {
                if (hand[i].SuitProp.IsWild())
                {
                    jokerCount += 1;
                    i++;
                    continue;
                }

                // If we keep descending we're fine
                // TODO: This doesn't work for wrap around aces yet. I'm cutting this work short to fit within time.
                int prevValue = hand[i - 1].ValueProp.GetHighestValue();
                if (!hand[i].ValueProp.Compare(prevValue - 1))
                {
                    return false;
                }
            }

            return true;
        }
    }
}