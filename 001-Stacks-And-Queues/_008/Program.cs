namespace _008;

internal static class TrafficJam
{
    private static void Main(string[] args)
    {
        var greenLight = int.Parse(Console.ReadLine());
        var cars = new Queue<string>();
        var command = Console.ReadLine();
        var counter = 0;
        while (command != "end")
        {
            if (command == "green")
            {
                var count = cars.Count;
                for (var i = 0; i < (count < greenLight ? count : greenLight); i++)
                {
                    Console.WriteLine($"{cars.Dequeue()} passed!");
                    counter++;
                }

                command = Console.ReadLine();
                continue;
            }

            cars.Enqueue(command);
            command = Console.ReadLine();
        }

        Console.WriteLine($"{counter} cars passed the crossroads.");
    }
}