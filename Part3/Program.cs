class Program

{
    static void Main(string[] args)
    {
        ArrayList<int> arrayList = new ArrayList<int>();
        arrayList.Add(10);
        arrayList.Add(20);
        arrayList.Add(30);

        Console.WriteLine("Element at index 1: " + arrayList[1]);
        Console.WriteLine("Total elements in ArrayList: " + arrayList.Count);

        // Clear the ArrayList
        arrayList.Clear();
        Console.WriteLine("After clearing, Total elements in ArrayList: " + arrayList.Count);

        // Add range of elements
        List<int> range = new List<int> { 40, 50, 60 };
        arrayList.AddRange(range);
        Console.WriteLine("After adding range, Total elements in ArrayList: " + arrayList.Count);
    }
}

