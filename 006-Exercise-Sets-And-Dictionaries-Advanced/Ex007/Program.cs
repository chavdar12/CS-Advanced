namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var usernames = new HashSet<string>();
        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++) usernames.Add(Console.ReadLine());

        Console.WriteLine(string.Join(Environment.NewLine, usernames));
    }
}