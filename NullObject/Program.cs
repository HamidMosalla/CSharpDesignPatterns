using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Remember null object is an anti pattern: https://stackoverflow.com/questions/1178399/how-do-i-create-a-null-object-in-c-sharp
            IAnimal dog = new Dog();
            dog.MakeSound();

           // replace Animal.Null with null and you'll get an exception
            IAnimal unknown = Animal.Null; 
            unknown.MakeSound();
        }
    }
}
