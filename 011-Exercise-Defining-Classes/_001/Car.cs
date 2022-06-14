namespace _001;

public class Car
{
    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public string Model { get; set; }
    private double FuelAmount { get; set; }
    private double FuelConsumptionPerKm { get; set; }
    private double TravelledDistance { get; set; }

    public void Drive(double distance)
    {
        var fuelConsumed = distance * FuelConsumptionPerKm;
        if (FuelAmount - fuelConsumed >= 0)
        {
            FuelAmount -= fuelConsumed;
            TravelledDistance += distance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public override string ToString()
    {
        return $"{Model} {FuelAmount:f2} {TravelledDistance}";
    }
}