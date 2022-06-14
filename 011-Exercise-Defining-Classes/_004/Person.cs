namespace _004;

public class Person
{
    private Person(int age)
    {
        Age = age;
    }

    public Person(int age, string name)
        : this(age)
    {
        Name = name;
    }

    public string Name { get; set; } = "No name";
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Age}";
    }
}