namespace wompa.source.card
{
    public class AceValueProp : IValueProp
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
            return (testValue == 14 || testValue == 1);
        }

        public string GetNameFormat()
        {
            return "Ace of {0}";
        }
    }
}