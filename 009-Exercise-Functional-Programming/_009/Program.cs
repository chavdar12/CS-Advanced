namespace _009;

internal static class PredicateParty
{
    private static void Main(string[] args)
    {
        var partyPeople = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
        string input;
        while ((input = Console.ReadLine()) != "Party!")
        {
            var commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var command = GetPredicate(commands[1], commands[2]);
            switch (commands[0])
            {
                case "Double":
                    var doubleIt = partyPeople.FindAll(command);
                    if (doubleIt.Any())
                    {
                        var idx = partyPeople.FindIndex(command);
                        partyPeople.InsertRange(idx, doubleIt);
                    }

                    break;
                case "Remove":
                    partyPeople.RemoveAll(command);
                    break;
            }
        }

        Console.WriteLine(partyPeople.Any()
            ? $"{string.Join(", ", partyPeople)} are going to the party!"
            : "Nobody is going to the party!");
    }

    private static Predicate<string> GetPredicate(string commandType, string arg)
    {
        return commandType switch
        {
            "StartsWith" => (name) => name.StartsWith(arg),
            "EndsWith" => (name) => name.EndsWith(arg),
            "Length" => (name) => name.Length == int.Parse(arg),
            _ => throw new ArgumentException("Invalid command type: " + commandType)
        };
    }
}