namespace wompa.source.card
{
    public class WildValueProp : IValueProp
    {
        public int GetHighestValue()
        {
            return 14;
        }

        public int GetLowestValue()
        {
            return 1;
        }

        public bool Compare(int testValue)
        {
            return true;
        }

        public string GetNameFormat()
        {
            return "Joker";
        }
    }
}