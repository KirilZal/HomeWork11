using System;
using System.Reflection.Metadata.Ecma335;

namespace HomeWork11
{ 
  class MyClass<T>
    {
        public static T FactoryMethod()
        {
            return default(T);

        }
    }
    class Myclass2<T> where T: new()
    {
        public static T Fabryk()
        {
            return new T();

        }
    }
    
}
