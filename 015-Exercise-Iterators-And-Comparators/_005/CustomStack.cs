using System.Collections;

namespace _005;

public class CustomStack<T> : IEnumerable<T>
{
    private List<T> myStack;

    public CustomStack()
    {
        myStack = new List<T>();
    }

    private int Count { get; set; }

    public void Push(T item)
    {
        myStack.Insert(0, item);
        Count++;
    }

    public void Pop()
    {
        if (Count == 0)
        {
            Console.WriteLine("No elements");
            return;
        }

        myStack.RemoveAt(0);
        Count--;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (var i = 0; i < Count; i++) yield return myStack[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}