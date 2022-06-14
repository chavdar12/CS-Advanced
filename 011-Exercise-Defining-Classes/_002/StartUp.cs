namespace _002;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        var engineModels = new List<Engine>();
        for (var i = 0; i < n; i++)
        {
            var engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var currentEngine = new Engine(engineInfo[0], engineInfo[1]);
            try
            {
                if (int.TryParse(engineInfo[2], out _))
                    currentEngine.Displacement = engineInfo[2];
                else
                    currentEngine.Efficiency = engineInfo[2];
                if (int.TryParse(engineInfo[3], out _))
                    currentEngine.Displacement = engineInfo[3];
                else
                    currentEngine.Efficiency = engineInfo[3];
            }
            catch (Exception)
            {
                // ignored
                continue;
            }

            engineModels.Add(currentEngine);
        }

        var m = int.Parse(Console.ReadLine());
        for (var i = 0; i < m; i++)
        {
            var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var currentCar = new Car(carInfo[0], engineModels.First(e => e.Model == carInfo[1]));
            try
            {
                if (int.TryParse(carInfo[2], out _))
                    currentCar.Weight = carInfo[2];
                else
                    currentCar.Color = carInfo[2];
                if (int.TryParse(carInfo[3], out _))
                    currentCar.Weight = carInfo[3];
                else
                    currentCar.Color = carInfo[3];
            }
            catch (Exception)
            {
                // ignored
                continue;
            }

            cars.Add(currentCar);
        }

        Console.WriteLine(string.Join(Environment.NewLine, cars));
    }
}