namespace _006;

public class Engine
{
    public Engine(int speed, int power)
    {
        Speed = speed;
        Power = power;
    }

    private int Speed { get; set; }
    public int Power { get; set; }
}