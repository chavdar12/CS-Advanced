namespace _011;

internal static class ThePartyReservationFilterModule
{
    private static void Main(string[] args)
    {
        var partyPeople = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
        var filters = new Dictionary<string, Predicate<string>>();
        string input;
        while ((input = Console.ReadLine()) != "Print")
        {
            var addRemFilter = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
            var addRemove = addRemFilter[0];
            var condition = addRemFilter[1];
            var argument = addRemFilter[2];
            switch (addRemove)
            {
                case "Add filter":
                    var currentPredicate = GetPredicate(condition, argument);
                    filters.Add(argument, currentPredicate);
                    break;
                case "Remove filter":
                    GetPredicate(condition, argument);
                    filters.Remove(argument);
                    break;
            }
        }

        foreach (var filter in filters) partyPeople.RemoveAll(filter.Value);
        Console.WriteLine(string.Join(" ", partyPeople));
    }

    private static Predicate<string> GetPredicate(string commandType, string arg)
    {
        return commandType switch
        {
            "Starts with" => (name) => name.StartsWith(arg),
            "Ends with" => (name) => name.EndsWith(arg),
            "Length" => (name) => name.Length == int.Parse(arg),
            "Contains" => (name) => name.Contains(arg),
            _ => throw new ArgumentException("Invalid command type: " + commandType)
        };
    }
}