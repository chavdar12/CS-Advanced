namespace _002;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var integer = new Box<int>(int.Parse(Console.ReadLine()));
            Console.WriteLine(integer);
        }
    }
}