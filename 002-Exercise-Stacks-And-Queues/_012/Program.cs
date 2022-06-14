namespace _012;

internal static class TruckTour
{
    private static void Main(string[] args)
    {
        var numPumps = int.Parse(Console.ReadLine());
        var pumps = new Queue<Pump>();
        long petrolAmount = 0;
        for (var i = 0; i < numPumps; i++)
        {
            var amountDistance = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var currentPump = new Pump(i, amountDistance[0], amountDistance[1]);
            pumps.Enqueue(currentPump);
        }

        var isEnough = false;
        var counter = 0;
        while (!isEnough)
        {
            petrolAmount += pumps.Peek().PetrolAmount;
            if (petrolAmount >= pumps.Peek().DistanceToNext)
            {
                counter++;
                petrolAmount -= pumps.Peek().DistanceToNext;
            }
            else
            {
                petrolAmount = 0;
                counter = 0;
            }

            pumps.Enqueue(pumps.Dequeue());
            if (counter == numPumps) isEnough = true;
        }

        Console.WriteLine(pumps.Peek().Name);
    }
}

internal class Pump
{
    public Pump(int name, long amount, long distance)
    {
        Name = name;
        PetrolAmount = amount;
        DistanceToNext = distance;
    }

    public long PetrolAmount { get; set; }
    public long DistanceToNext { get; set; }
    public int Name { get; set; }
}