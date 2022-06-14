using Threeuple;

namespace _008;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var first = Console.ReadLine().Split();
        var name = $"{first[0]} {first[1]}";
        var address = first[2];
        var town = first.Length > 4 ? first[3] + " " + first[4] : first[3];
        var firstThreeuple = new Threeuple<string, string, string>(name, address, town);
        Console.WriteLine(firstThreeuple);
        var second = Console.ReadLine().Split();
        var secondThreeuple =
            new Threeuple<string, int, bool>(second[0], int.Parse(second[1]), second[2].ToLower() == "drunk");
        Console.WriteLine(secondThreeuple);
        var third = Console.ReadLine().Split();
        var thirdThreeuple = new Threeuple<string, double, string>(third[0], double.Parse(third[1]), third[2]);
        Console.WriteLine(thirdThreeuple);
    }
}