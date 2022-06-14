namespace _003;

internal static class FilterByAge
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var people = new Dictionary<string, int>();
        for (var i = 0; i < n; i++)
        {
            var person = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var name = person[0];
            var age = int.Parse(person[1]);
            people.Add(name, age);
        }

        Func<int, int, bool>? cond = Console.ReadLine() switch
        {
            "older" => (i, j) => i >= j,
            "younger" => (i, j) => i < j,
            _ => null
        };

        var ageFilter = int.Parse(Console.ReadLine());
        var filter = Console.ReadLine();
        switch (filter)
        {
            case "name":
                foreach (var person in people.Where(p => cond(p.Value, ageFilter))) Console.WriteLine(person.Key);

                break;
            case "age":
                foreach (var person in people.Where(p => cond(p.Value, ageFilter))) Console.WriteLine(person.Value);

                break;
            case "name age":
                foreach (var (key, value) in people.Where(p => cond(p.Value, ageFilter)))
                    Console.WriteLine($"{key} - {value}");

                break;
        }
    }
}