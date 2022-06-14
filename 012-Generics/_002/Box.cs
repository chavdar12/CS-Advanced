﻿namespace _002;

public class Box<T>
{
    private readonly Stack<T> box;

    public Box()
    {
        box = new Stack<T>();
    }

    public int Count => box.Count;

    public void Add(T item)
    {
        box.Push(item);
    }

    public T Remove()
    {
        return box.Pop();
    }
}