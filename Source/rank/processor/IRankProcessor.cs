using wompa.source.card;

namespace wompa.source.rank.processor
{
    public interface IRankProcessor
    {
        bool Match(CardEntity[] hand);
    }
}