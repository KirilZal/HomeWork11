using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CarCollection carcoll = new CarCollection(5);
            string input;
            do
            {
                Console.WriteLine("Enter the name of the machine: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the year of production: ");
                int years;
                if (int.TryParse(Console.ReadLine(), out years))
                {
                    carcoll.AddCar(name, years);
                }
                else
                {
                    Console.WriteLine("Invalid year format. Please enter a valid integer year.");
                }

                Console.WriteLine("If you want to add another car, enter 'yes'.");
                input = Console.ReadLine();

            } while (input.ToLower() == "yes");

            Console.WriteLine("Cars in the collection:");
            for (int i = 0; i < carcoll.Count; i++)
            {
                Console.WriteLine($"Car {i + 1}: {carcoll[i]?.Name}, Year: {carcoll[i]?.Years}");
            }
        }
    }


}
    
