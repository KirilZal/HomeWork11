

using System;


namespace HomeWork11
{
    class CarCollection
    {
        private int count;
        private Car[] cars;

        public CarCollection(int capacity)
        {
            cars = new Car[capacity];
            count = 0;
        }

        public void AddCar(string name, int years)
        {
            
            
            if (count < cars.Length)
            {
                cars[count] = new Car(name, years);
                count++;
            }
            else 
            {
                Console.WriteLine("Autopark is full");
            }
        }

        public Car this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return cars[index];
                }
                else
                {
                    Console.WriteLine("There is no car at this index.");
                    return null; 
                }
            }
        }

        public int Count => count;

        public void Clear()
        {
            count = 0;
            Array.Clear(cars, 0, cars.Length); 
        }
    }
}







