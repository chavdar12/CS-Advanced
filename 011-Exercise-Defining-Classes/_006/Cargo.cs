namespace _006;

public class Cargo
{
    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type;
    }

    private int Weight { get; set; }
    public string Type { get; set; }
}