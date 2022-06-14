namespace _010;

internal static class ReverseAndExclude
{
    private static void Main(string[] args)
    {
        void Reverse(IList<int> i)
        {
            for (var j = 0; j < i.Count / 2; j++) (i[j], i[i.Count - 1 - j]) = (i[i.Count - 1 - j], i[j]);
        }

        var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var n = int.Parse(Console.ReadLine());

        bool Filter(int i)
        {
            return i % n != 0;
        }

        Reverse(numbers);
        Console.WriteLine(string.Join(" ", numbers.ToList().FindAll(Filter)));
    }
}