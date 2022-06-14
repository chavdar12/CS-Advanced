using System.Text;

namespace _007;

public class Car
{
    public Car(string make, string model, int horsePower, string registrationNumber)
    {
        Make = make;
        Model = model;
        HorsePower = horsePower;
        RegistrationNumber = registrationNumber;
    }

    public string Make { get; set; }
    private string Model { get; set; }
    private int HorsePower { get; set; }
    public string RegistrationNumber { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Make: {Make}");
        sb.AppendLine($"Model: {Model}");
        sb.AppendLine($"HorsePower: {HorsePower}");
        sb.AppendLine($"RegistrationNumber: {RegistrationNumber}");

        return sb.ToString().Trim();
    }
}