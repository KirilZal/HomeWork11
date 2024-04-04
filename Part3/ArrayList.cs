using System;
using System.Collections.Generic;

class ArrayList<T>
{
    private T[] array;
    private int count;
    private const int defaultCapacity = 4;

    public ArrayList()
    {
        array = new T[defaultCapacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == array.Length)
        {
            ResizeArray();
        }
        array[count++] = item;
    }

    public void AddRange(IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            Add(item);
        }
    }

    public void Clear()
    {
        count = 0;
        Array.Clear(array, 0, array.Length);
    }

    private void ResizeArray()
    {
        int newCapacity = array.Length * 2;
        T[] newArray = new T[newCapacity];
        Array.Copy(array, newArray, array.Length);
        array = newArray;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index out of range");
                return default(T); // Повернення значення за замовчуванням
            }
            return array[index];
        }
        set
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index out of range");
                return;
            }
            array[index] = value;
        }
    }

    public int Count
    {
        get { return count; }
    }
}

