using System.Collections;

namespace _004;

public class ListyIterator<T> : IEnumerable<T>
{
    private int currentIndex;

    public ListyIterator(params T[] list)
    {
        Create(list);
    }

    private List<T> Elements { get; set; }

    private void Create(params T[] list)
    {
        Elements = list.ToList();
        currentIndex = 0;
    }

    public bool Move()
    {
        if (Elements.Count <= 0) return false;
        if (currentIndex == Elements.Count - 1) return false;
        currentIndex++;
        return true;
    }

    public void Print()
    {
        if (Elements.Count == 0)
        {
            Console.WriteLine("Invalid Operation!");
            return;
        }

        Console.WriteLine(Elements[currentIndex]);
    }

    public void PrintAll()
    {
        foreach (var element in Elements) Console.Write(element + " ");

        Console.WriteLine();
    }

    public bool HasNext()
    {
        if (Elements.Count == 0) return false;

        return currentIndex + 1 < Elements.Count;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>) Elements).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}