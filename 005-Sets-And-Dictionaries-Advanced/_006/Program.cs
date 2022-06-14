namespace _006;

internal static class RecordUniqueNames
{
    private static void Main(string[] args)
    {
        var names = new HashSet<string>();
        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var name = Console.ReadLine();
            names.Add(name);
        }

        Console.WriteLine(string.Join("\n", names));
    }
}