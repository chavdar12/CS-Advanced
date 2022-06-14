using System.Text;

namespace _001;

public class Car
{
    public Car()
    {
        Make = "VW";
        Model = "Golf";
        Year = 2025;
        FuelQuantity = 200;
        FuelConsumption = 10;
    }

    private Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    private Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine,
        Tire[] tires)
        : this(make, model, year, fuelQuantity, fuelConsumption)
    {
        Engine = engine;
        Tires = tires;
    }

    private string Make { get; set; }

    private string Model { get; set; }

    public int Year { get; set; }

    private double FuelQuantity { get; set; }

    private double FuelConsumption { get; set; }

    public Engine Engine { get; set; }

    public Tire[] Tires { get; set; }

    public void Drive(double distance)
    {
        var fuelConsumed = distance * (FuelConsumption / 100);
        if (FuelQuantity - fuelConsumed >= 0)
            FuelQuantity -= fuelConsumed;
        else
            Console.WriteLine("Not enough fuel to perform this trip!");
    }

    public string WhoAmI()
    {
        var sb = new StringBuilder();
        sb.Append(
            $"Make: {Make}\nModel: {Model}\nYear: {Year}\nHorsePowers: {Engine.HorsePower}\nFuelQuantity: {FuelQuantity}");
        return sb.ToString();
    }
}