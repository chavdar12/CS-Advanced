namespace _001;

public class Tire
{
    public Tire(int year, double pressure)
    {
        Year = year;
        Pressure = pressure;
    }

    private int Year { get; set; }

    public double Pressure { get; set; }
}