namespace _001;

internal static class CountSymbols
{
    private static void Main(string[] args)
    {
        var symbols = new SortedDictionary<char, int>();
        var sentence = Console.ReadLine();
        foreach (var symbol in sentence)
        {
            if (!symbols.ContainsKey(symbol)) symbols.Add(symbol, 0);

            symbols[symbol]++;
        }

        foreach (var (key, value) in symbols) Console.WriteLine($"{key}: {value} time/s");
    }
}