namespace _002;

public class Car
{
    public Car(string model, Engine engine)
    {
        Model = model;
        Engine = engine;
    }

    private string Model { get; set; }
    private Engine Engine { get; set; }
    public string Weight { get; set; } = "n/a";
    public string Color { get; set; } = "n/a";

    public override string ToString()
    {
        return $"{Model}:\n  {Engine}\n  Weight: {Weight}\n  Color: {Color}";
    }
}