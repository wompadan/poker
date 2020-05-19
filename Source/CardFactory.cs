using System;
using wompa.source.card;
using wompa.source.core;

namespace wompa.source
{
    public static class CardFactory
    {
        // Generate an array of cards based on a simple space delimited string
        public static CardEntity[] GenerateHand(string desc)
        {
            CardEntity[] hand = new CardEntity[5];

            string[] array = desc.Split(' ');
            for (int i = 0; i < array.Length; ++i)
            {
                hand[i] = GenerateCard(array[i]);
            }

            Sort(hand);
            return hand;
        }
        
        // Generate an object based on simple string of value and suit, such as "3H" or "KD" or just "J"
        public static CardEntity GenerateCard(string desc)
        {
            // TODO: Create a pool for cards and recycle the entities after each ranking.
            CardEntity card = new CardEntity();

            if (desc == "J") return CreateJoker(card);
            if (desc.Length < 2) return null;
            if (desc.Length > 2)
            {
                if (!desc.StartsWith("10")) return null;
            }

            string valueString = desc.Substring(0, desc.Length-1);
            card.ValueProp = GenerateValue(valueString);
            
            string suitString = desc.Substring(desc.Length - 1, 1);
            card.SuitProp = GenerateSuit(suitString);
            
            return card;
        }

        private static CardEntity CreateJoker(CardEntity card)
        {
            card.ValueProp = new WildValueProp();
            card.SuitProp = new WildSuitProp();
            return card;
        }

        private static IValueProp GenerateValue(string desc)
        {
            switch (desc)
            {
                case "A":
                    return new AceValueProp();
                case "K":
                    return new StandardValueProp(13, "King");
                case "Q":
                    return new StandardValueProp(12, "Queen");
                case "J":
                    return new StandardValueProp(11, "Jack");
                default:
                    int value = -1;
                    value = Convert.ToInt32(desc);
                    if (value > 1) return new StandardValueProp(value, desc);
                    break;
            }

            return null;
        }

        private static ISuitProp GenerateSuit(string desc)
        {
            switch (desc)
            {
                case "H":
                    return new StandardSuitProp(Suit.Hearts);
                case "D":
                    return new StandardSuitProp(Suit.Diamonds);
                case "S":
                    return new StandardSuitProp(Suit.Spades);
                case "C":
                    return new StandardSuitProp(Suit.Clubs);
                default:
                    return null;
            }
        }
        
        private static void Sort(CardEntity[] hand)
        {
            Array.Sort(hand, SortByRank);
        }

        private static int SortByRank(CardEntity a, CardEntity b)
        {
            if (a.SuitProp.IsWild() && b.SuitProp.IsWild()) return 0;
            if (a.SuitProp.IsWild()) return -1;
            if (b.SuitProp.IsWild()) return 1;
            return b.ValueProp.GetHighestValue() - a.ValueProp.GetHighestValue();
        }
    }
}