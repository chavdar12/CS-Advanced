namespace Ex003;

public static class DateModifier
{
    public static double GetDifferenceOfDates(DateTime date1, DateTime date2)
    {
        var compareDates = date1.CompareTo(date2);

        switch (compareDates)
        {
            case -1:
                return (date2 - date1).TotalDays;
            case 1:
                return (date1 - date2).TotalDays;
            default:
                return 0;
        }
    }
}