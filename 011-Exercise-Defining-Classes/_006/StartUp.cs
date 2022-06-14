namespace _006;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        for (var i = 0; i < n; i++)
        {
            var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var model = carInfo[0];
            var engSpeed = int.Parse(carInfo[1]);
            var engPower = int.Parse(carInfo[2]);
            var cargoWeight = int.Parse(carInfo[3]);
            var cargoType = carInfo[4];
            var tire1Pressure = double.Parse(carInfo[5]);
            var tire1Age = int.Parse(carInfo[6]);
            var tire2Pressure = double.Parse(carInfo[7]);
            var tire2Age = int.Parse(carInfo[8]);
            var tire3Pressure = double.Parse(carInfo[9]);
            var tire3Age = int.Parse(carInfo[10]);
            var tire4Pressure = double.Parse(carInfo[11]);
            var tire4Age = int.Parse(carInfo[12]);
            var currentCargo = new Cargo(cargoWeight, cargoType);
            var tire1 = new Tire(tire1Age, tire1Pressure);
            var tire2 = new Tire(tire2Age, tire2Pressure);
            var tire3 = new Tire(tire3Age, tire3Pressure);
            var tire4 = new Tire(tire4Age, tire4Pressure);
            var tires = new List<Tire>
            {
                tire1,
                tire2,
                tire3,
                tire4
            };
            var currentEngine = new Engine(engSpeed, engPower);
            var currentCar = new Car(model, currentEngine, tires, currentCargo);
            cars.Add(currentCar);
        }

        var filterCargoType = Console.ReadLine();
        if (filterCargoType == "fragile")
            Console.WriteLine(string.Join(Environment.NewLine,
                cars.FindAll(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))));
        else if (filterCargoType == "flammable")
            Console.WriteLine(string.Join(Environment.NewLine,
                cars.FindAll(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)));
    }
}