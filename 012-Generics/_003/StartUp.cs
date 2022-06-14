namespace _003;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var numbers = new EqualityScale<int>(3, 3);
        Console.WriteLine(numbers.AreEqual());
    }
}