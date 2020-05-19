using wompa.source.core;

namespace wompa.source.card
{
    public interface ISuitProp
    {
        bool IsWild();
        bool Compare(Suit testValue);
        Suit GetMatchingSuit();
    }
}