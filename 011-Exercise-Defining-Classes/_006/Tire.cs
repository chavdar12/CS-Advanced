namespace _006;

public class Tire
{
    public Tire(int age, double pressure)
    {
        Age = age;
        Pressure = pressure;
    }

    private int Age { get; set; }
    public double Pressure { get; set; }
}