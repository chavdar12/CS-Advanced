namespace _001;

public class BookComparator : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return x.Title != y.Title
            ? string.Compare(x.Title, y.Title, StringComparison.Ordinal)
            : y.Year.CompareTo(x.Year);
    }
}