namespace _001;

public class Person : IComparable<Person>
{
    public Person(string name, int age, string town)
    {
        Name = name;
        Age = age;
        Town = town;
    }

    private string Name { get; set; }
    private int Age { get; set; }
    private string Town { get; set; }

    public int CompareTo(Person other)
    {
        if (string.Compare(Name, other.Name, StringComparison.Ordinal) != 0) return Name.CompareTo(other.Name);

        if (Age.CompareTo(other.Age) != 0) return Age.CompareTo(other.Age);

        return string.Compare(Town, other.Town, StringComparison.Ordinal) != 0 ? Town.CompareTo(other.Town) : 0;
    }
}