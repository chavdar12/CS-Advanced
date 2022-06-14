namespace _009;

public class Tuple<T, TV>
{
    public Tuple(T item1, TV item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    private T Item1 { get; set; }
    private TV Item2 { get; set; }

    public override string ToString()
    {
        return $"{Item1} -> {Item2}";
    }
}