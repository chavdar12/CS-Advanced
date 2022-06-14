namespace _003;

public static class DateModifier
{
    public static double GetDifferenceOfDates(DateTime date1, DateTime date2)
    {
        var compareDates = date1.CompareTo(date2);

        return compareDates switch
        {
            -1 => (date2 - date1).TotalDays,
            1 => (date1 - date2).TotalDays,
            _ => 0
        };
    }
}