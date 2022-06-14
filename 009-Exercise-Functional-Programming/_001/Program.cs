namespace _001;

internal static class ActionPoint
{
    private static void Main(string[] args)
    {
        void Print(string str)
        {
            Console.WriteLine(str);
        }

        Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(Print);
    }
}