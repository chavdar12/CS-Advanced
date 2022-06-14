namespace _006;

internal static class FashionBoutique
{
    private static void Main(string[] args)
    {
        var clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        var rackCapacity = int.Parse(Console.ReadLine());
        var currentRackClothes = 0;
        var rackCounter = 1;

        while (clothes.Count > 0)
        {
            if (currentRackClothes + clothes.Peek() > rackCapacity)
            {
                currentRackClothes = 0;
                rackCounter++;
            }

            currentRackClothes += clothes.Pop();
        }

        Console.WriteLine(rackCounter);
    }
}