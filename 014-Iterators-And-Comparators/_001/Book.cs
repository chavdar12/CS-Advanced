namespace _001;

public class Book : IComparable<Book>
{
    public Book(string title, int year, params string[] authors)
    {
        Title = title;
        Year = year;
        Authors = authors;
    }

    public string Title { get; private set; }
    public int Year { get; private set; }
    private IReadOnlyList<string> Authors { get; set; }

    public int CompareTo(Book other)
    {
        return Year != other.Year
            ? Year.CompareTo(other.Year)
            : string.Compare(Title, other.Title, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{Title} - {Year}";
    }
}