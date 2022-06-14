namespace _004;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var family = new Family();
        for (var i = 0; i < n; i++)
        {
            var member = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var currentPerson = new Person(int.Parse(member[1]), member[0]);
            family.AddMember(currentPerson);
        }

        family.FamilyMembers.Where(m => m.Age > 30).OrderBy(m => m.Name).ToList().ForEach(Console.WriteLine);
    }
}