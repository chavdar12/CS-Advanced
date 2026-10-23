namespace Ex001;

public class DoublyLinkedList<T>
{
    public class ListNode
    {
        public ListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public ListNode Previous { get; set; }
        public ListNode Next { get; set; }
    }

    private ListNode Head { get; set; }
    private ListNode Tail { get; set; }
    public int Count { get; private set; }

    public void AddFirst(T element)
    {
        if (Count == 0)
        {
            Head = Tail = new ListNode(element);
        }
        else
        {
            var currentListNode = new ListNode(element);
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
            Head = Tail = new ListNode(element);
        }
        else
        {
            var currentListNode = new ListNode(element);
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
        if (Head == null) Tail = null;
        else Head.Previous = null;

        Count--;
        return firstListNode;
    }

    public T RemoveLast()
    {
        if (Count == 0) throw new InvalidOperationException("The list is empty");

        var lastListNode = Tail.Value;
        Tail = Tail.Previous;
        if (Tail == null) Head = null;
        else Tail.Next = null;

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