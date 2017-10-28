using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
