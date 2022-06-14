namespace _002;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var sorted = new SortedSet<Person>(new Comparer());
        var hash = new HashSet<Person>();
        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var person = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var name = person[0];
            var age = int.Parse(person[1]);
            var currentPerson = new Person() {Age = age, Name = name};
            sorted.Add(currentPerson);
            hash.Add(currentPerson);
        }

        Console.WriteLine(sorted.Count);
        Console.WriteLine(hash.Count);
    }
}