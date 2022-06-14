namespace _003;

public class EqualityScale<T>
{
    public EqualityScale(T left, T right)
    {
        Left = left;
        Right = right;
    }

    private T Left { get; set; }
    private T Right { get; set; }

    public bool AreEqual()
    {
        return Left.Equals(Right);
    }
}