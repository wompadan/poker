using wompa.source.card;

namespace wompa.source.rank.processor
{
    public class NofaKindRankProcessor : IRankProcessor
    {
        private int _requiredCount;
        
        public NofaKindRankProcessor(int requiredCount)
        {
            _requiredCount = requiredCount;
        }
        
        public bool Match(CardEntity[] hand)
        {
            int currentCount = 1;
            int wildCount = hand[0].SuitProp.IsWild() ? 1 : 0;
            for (int i = 1; i < 5; ++i)
            {
                if (hand[i].SuitProp.IsWild())
                {
                    wildCount += 1;
                    if (wildCount >= _requiredCount - 1)
                    {
                        return true;
                    }
                }
                int prevValue = hand[i - 1].ValueProp.GetHighestValue();
                if (hand[i].ValueProp.Compare(prevValue))
                {
                    currentCount++;
                    if (currentCount >= _requiredCount)
                    {
                        return true;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }

            return false;
        }
    }
}