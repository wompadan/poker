namespace wompa.source.card
{
    public class StandardValueProp : IValueProp
    {
        private int _value;
        private string _name;
        
        public StandardValueProp(int value, string name)
        {
            _value = value;
            _name = name;
        }
        
        public int GetHighestValue()
        {
            return _value;
        }

        public int GetLowestValue()
        {
            return _value;
        }

        public bool Compare(int testValue)
        {
            return _value == testValue;
        }

        public string GetNameFormat()
        {
            return $"{_name} of {{0}}";
        }
    }
}