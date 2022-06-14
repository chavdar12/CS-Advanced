namespace _002;

public class Comparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (string.Compare(x.Name, y.Name, StringComparison.Ordinal) != 0)
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);

        return x.Age.CompareTo(y.Age) != 0 ? x.Age.CompareTo(y.Age) : 0;
    }
}