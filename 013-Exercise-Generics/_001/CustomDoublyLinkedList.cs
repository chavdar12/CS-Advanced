namespace _001;

public class DoublyLinkedList<T>
{
    public class ListNode<T>
    {
        public ListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public ListNode<T> Previous { get; set; }
        public ListNode<T> Next { get; set; }
    }

    private ListNode<T> Head { get; set; }
    private ListNode<T> Tail { get; set; }
    public int Count { get; private set; }

    public void AddFirst(T element)
    {
        if (Count == 0)
        {
            Head = Tail = new ListNode<T>(element);
        }
        else
        {
            var currentListNode = new ListNode<T>(element);
            currentListNode.Next = Head;
            Head.Previous = currentListNode;
            Head = currentListNode;
        }

        Count++;
    }

    public void AddLast(T element)
    {
        if (Count == 0)
        {
            Head = Tail = new ListNode<T>(element);
        }
        else
        {
            var currentListNode = new ListNode<T>(element);
            currentListNode.Previous = Tail;
            Tail.Next = currentListNode;
            Tail = currentListNode;
        }

        Count++;
    }

    public T RemoveFirst()
    {
        if (Count == 0) throw new InvalidOperationException("The list is empty");

        var firstListNode = Head.Value;
        Head = Head.Next;
        Head.Previous = null;

        Count--;
        return firstListNode;
    }

    public T RemoveLast()
    {
        if (Count == 0) throw new InvalidOperationException("The list is empty");

        var lastListNode = Tail.Value;
        Tail = Tail.Previous;
        Tail.Next = null;

        Count--;
        return lastListNode;
    }

    public void ForEach(Action<T> action)
    {
        var currentListNode = Head;
        while (currentListNode != null)
        {
            action(currentListNode.Value);
            currentListNode = currentListNode.Next;
        }
    }

    public T[] ToArray()
    {
        var array = new T[Count];
        var currentListNode = Head;
        var counter = 0;
        while (currentListNode != null)
        {
            array[counter] = currentListNode.Value;
            currentListNode = currentListNode.Next;
            counter++;
        }

        return array;
    }
}