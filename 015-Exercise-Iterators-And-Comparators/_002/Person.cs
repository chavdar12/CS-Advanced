namespace _002;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person other)
    {
        if (string.Compare(Name, other.Name, StringComparison.Ordinal) != 0)
            return string.Compare(Name, other.Name, StringComparison.Ordinal);

        return Age.CompareTo(other.Age) != 0 ? Age.CompareTo(other.Age) : 0;
    }

    public override bool Equals(object? other)
    {
        var compare = (Person) other;
        return Name == compare.Name && Age == compare.Age;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() + Age.GetHashCode();
    }
}