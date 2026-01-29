namespace Ex001;

internal class Program
{
    private static void Main()
    {
        var strings = ArrayCreator.Create(5, "Pesho");
        var integers = ArrayCreator.Create(10, 33);

        foreach (var s in strings) Console.WriteLine(s);
        foreach (var i in integers) Console.WriteLine(i);
    }
}