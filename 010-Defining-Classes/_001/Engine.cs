namespace _001;

public class Engine
{
    public Engine(int horsePower, double cubicCapacity)
    {
        HorsePower = horsePower;
        CubicCapacity = cubicCapacity;
    }

    public int HorsePower { get; set; }

    private double CubicCapacity { get; set; }
}