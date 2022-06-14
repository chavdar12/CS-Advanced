namespace _002;

internal static class PascalTriangle
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var pascalTriangle = new long[n][];
        for (var i = 0; i < n; i++)
        {
            var row = new long[i + 1];
            row[0] = 1;
            row[i] = 1;
            for (var j = 1; j < i; j++) row[j] = pascalTriangle[i - 1][j] + pascalTriangle[i - 1][j - 1];

            pascalTriangle[i] = row;
            Console.WriteLine(string.Join(" ", pascalTriangle[i]));
        }
    }
}