namespace Ex003;

internal class Program
{
    private static void Main()
    {
        var scale = new EqualityScale<int>(5, 5);
        Console.WriteLine(scale.AreEqual());
    }
}