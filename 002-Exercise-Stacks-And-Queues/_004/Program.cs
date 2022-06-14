namespace _004;

internal static class Crossroads
{
    private static void Main(string[] args)
    {
        var greenLight = int.Parse(Console.ReadLine());
        var freeWindowTime = int.Parse(Console.ReadLine());
        var command = Console.ReadLine();
        var cars = new Queue<string>();
        var counter = 0;
        while (command != "END")
        {
            var greenLightLeft = greenLight;
            var freeWindowLeft = freeWindowTime;
            switch (command)
            {
                case "green":
                    while (greenLightLeft > 0 && cars.Any())
                    {
                        var car = cars.Dequeue();
                        greenLightLeft -= car.Length;
                        if (greenLightLeft >= 0)
                        {
                            counter++;
                        }
                        else
                        {
                            freeWindowLeft += greenLightLeft;
                            if (freeWindowLeft < 0)
                            {
                                Console.WriteLine(
                                    $"A crash happened!{Environment.NewLine}{car} was hit at {car[car.Length + freeWindowLeft]}.");
                                return;
                            }

                            counter++;
                        }
                    }

                    break;
                default:
                    cars.Enqueue(command);
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"Everyone is safe.{Environment.NewLine}{counter} total cars passed the crossroads.");
    }
}