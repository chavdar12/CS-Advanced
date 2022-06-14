namespace _003;

public class Box<T>
{
    public Box(T value)
    {
        Value = value;
    }

    private T Value { get; set; }

    public override string ToString()
    {
        return $"{typeof(T)}: {Value}";
    }
}