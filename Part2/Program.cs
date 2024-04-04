using System;

class Dictionary<TKey, TValue>
{
    private TKey[] keys;
    private TValue[] values;
    private int count;

    public Dictionary(int capacity)
    {
        keys = new TKey[capacity];
        values = new TValue[capacity];
        count = 0;
    }

    public void Add(TKey key, TValue value)
    {
        if (count < keys.Length)
        {
            keys[count] = key;
            values[count] = value;
            count++;
        }
        else
        {
            Console.WriteLine("Dictionary is full. Cannot add more elements.");
        }
    }

    public TValue this[TKey key]
    {
        get
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i].Equals(key))
                {
                    return values[i];
                }
            }
            return default(TValue); 
        }
    }

    public int Count
    {
        get { return count; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDictionary = new Dictionary<string, int>(5);

        myDictionary.Add("one", 1);
        myDictionary.Add("two", 2);
        myDictionary.Add("three", 3);

        Console.WriteLine("Value corresponding to key 'one': " + myDictionary["one"]);
        Console.WriteLine("Value corresponding to key 'four': " + myDictionary["four"]); 
        Console.WriteLine("Total elements in dictionary: " + myDictionary.Count);
    }
}
