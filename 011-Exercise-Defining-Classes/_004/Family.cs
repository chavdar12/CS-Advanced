namespace _004;

public class Family
{
    public Family()
    {
        FamilyMembers = new List<Person>();
    }

    public List<Person> FamilyMembers { get; set; }

    public void AddMember(Person person)
    {
        FamilyMembers.Add(person);
    }

    public Person GetOldestPerson()
    {
        var maxAge = FamilyMembers.Max(m => m.Age);
        return FamilyMembers.First(m => m.Age == maxAge);
    }
}