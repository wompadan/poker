using System;
using wompa.source.card;
using wompa.source.rank.processor;

namespace wompa.source.rank
{
    public class HandRanker
    {
        private IRankProcessor[] _rankProcessors;
        
        public HandRanker()
        {
            _rankProcessors = new IRankProcessor[]
            {
                // TODO HighCard Processor
                new NofaKindRankProcessor(2),
                // TODO TwoPair Processor
                new NofaKindRankProcessor(3),
                new StraightRankProcessor(),
                new FlushRankProcessor(),
                // TODO FullHouse Processor
                new NofaKindRankProcessor(4),
                // TODO StraightFlush Processor
                new RoyalFlushRankProcessor(),
                new NofaKindRankProcessor(5)
            };
        }
        
        // Returns 1 if handA is ranked higher, -1 if handB is ranked higher, and 0 if they are a dead tie
        public int CompareHands(CardEntity[] handA, CardEntity[] handB)
        {
            int scoreA = GetScore(handA);
            int scoreB = GetScore(handB);

            if (scoreA < scoreB) return -1;
            if (scoreB < scoreA) return 1;
            return 0;
        }

        public int GetScore(CardEntity[] hand)
        {
            // Score can be calculated by identifying an order of magnitude for which position in the ranking system
            int score = 0;
            for (int i = _rankProcessors.Length - 1; i >= 0; --i)
            {
                if (_rankProcessors[i].Match(hand))
                {
                    score = 1000 * (i + 1);
                    break;
                }
            }

            // TODO: Calculate remaining tie-breaking portion of score and add
            return score;
        }
    }
}