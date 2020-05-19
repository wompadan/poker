using wompa.source.card;

namespace wompa.source
{
    public static class CardFactory
    {
        // Generate an array of cards based on a simple space delimited string
        public static CardEntity[] GenerateHand(string desc)
        {
            CardEntity[] hand = new CardEntity[5];
            return hand;
        }
        
        // Generate an object based on simple string of value and suit, such as "3H" or "KD" or just "J"
        public static CardEntity GenerateCard(string desc)
        {
            // TODO: Create a pool for cards and recycle the entities after each ranking.
            CardEntity card = new CardEntity();
            return card;
        }
    }
}