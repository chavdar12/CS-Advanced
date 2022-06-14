namespace _006;

public class Car
{
    public Car(string model, Engine engine, List<Tire> tires, Cargo cargo)
    {
        Model = model;
        Engine = engine;
        Tires = tires;
        Cargo = cargo;
    }

    private string Model { get; set; }
    public Engine Engine { get; set; }
    public List<Tire> Tires { get; set; }
    public Cargo Cargo { get; set; }

    public override string ToString()
    {
        return Model;
    }
}