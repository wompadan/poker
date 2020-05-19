namespace wompa.source.card
{
    public interface IValueProp
    {
        int GetHighestValue();
        int GetLowestValue();
        bool Compare(int testValue);
        string GetNameFormat();
    }
}