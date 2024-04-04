using HomeWork11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            int hey = MyClass<int>.FactoryMethod();
            string bay = MyClass<string>.FactoryMethod();
            hey = 12;
            bay="hi";
            Console.WriteLine(hey);
            Console.WriteLine(bay);

            
        }
    }
}
