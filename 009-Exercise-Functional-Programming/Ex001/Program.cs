namespace Ex001;

internal class Program
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