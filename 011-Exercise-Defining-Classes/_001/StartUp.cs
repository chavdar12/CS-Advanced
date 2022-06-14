namespace _001;

internal static class StartUp
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        string input;
        for (var i = 0; i < n; i++)
        {
            var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var currentCar = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            cars.Add(currentCar);
        }

        while ((input = Console.ReadLine()) != "End")
        {
            var drive = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            cars.First(c => c.Model == drive[1]).Drive(double.Parse(drive[2]));
        }

        Console.WriteLine(string.Join(Environment.NewLine, cars));
    }
}