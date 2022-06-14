namespace _001;

public static class StartUp
{
    private static void Main(string[] args)
    {
        string input;
        var matchesCount = 0;
        var countRestPeople = 0;
        var people = new List<Person>();
        while ((input = Console.ReadLine()) != "END")
        {
            var info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var currentPerson = new Person(info[0], int.Parse(info[1]), info[2]);
            people.Add(currentPerson);
        }

        var n = int.Parse(Console.ReadLine());

        if (people.Count > n)
        {
            var filterPerson = people[n - 1];
            foreach (var person in people)
                if (filterPerson.CompareTo(person) == 0)
                    matchesCount++;
                else
                    countRestPeople++;
        }

        Console.WriteLine(matchesCount > 0 ? $"{matchesCount} {countRestPeople} {people.Count}" : "No matches");
    }
}