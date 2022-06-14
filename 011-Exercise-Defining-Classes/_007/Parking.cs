namespace _007;

public class Parking
{
    public Parking(int capacity)
    {
        Cars = new List<Car>();
        Capacity = capacity;
    }

    private List<Car> Cars { get; set; }

    private int Capacity { get; set; }

    public int Count
        => Cars.Count;

    public string AddCar(Car car)
    {
        if (Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            return "Car with that registration number, already exists!";

        if (Count == Capacity) return "Parking is full!";

        Cars.Add(car);
        return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
    }

    public string RemoveCar(string registrationNumber)
    {
        if (Cars.All(c => c.RegistrationNumber != registrationNumber))
            return "Car with that registration number, doesn't exist!";

        Cars.Remove(Cars.First(c => c.RegistrationNumber == registrationNumber));
        return $"Successfully removed {registrationNumber}";
    }

    public Car GetCar(string registrationNumber)
    {
        return Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
    }

    public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
    {
        foreach (var registrationNumber in registrationNumbers)
            Cars.RemoveAll(c => c.RegistrationNumber == registrationNumber);
    }
}