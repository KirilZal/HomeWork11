using System;
using System.Collections;

namespace part4 
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("a");
            list.Add(2);
            list.Add("b");
            list.Add(new MyClass());
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        //проблема в тому що відбувается boxing ,unboxing?
        //треба уважно ставитись до додавання в список елементів бо можна заплутатись?
    }
    class MyClass { }

}
