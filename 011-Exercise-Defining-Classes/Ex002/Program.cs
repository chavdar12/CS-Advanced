namespace Ex002;

internal class Program
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
            foreach (var optional in engineInfo.Skip(2))
                if (int.TryParse(optional, out _))
                    currentEngine.Displacement = optional;
                else
                    currentEngine.Efficiency = optional;

            engineModels.Add(currentEngine);
        }

        var m = int.Parse(Console.ReadLine());
        for (var i = 0; i < m; i++)
        {
            var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var currentCar = new Car(carInfo[0], engineModels.First(e => e.Model == carInfo[1]));
            foreach (var optional in carInfo.Skip(2))
                if (int.TryParse(optional, out _))
                    currentCar.Weight = optional;
                else
                    currentCar.Color = optional;

            cars.Add(currentCar);
        }

        Console.WriteLine(string.Join(Environment.NewLine, cars));
    }
}