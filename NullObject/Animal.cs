using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    abstract class Animal : IAnimal
    {
        public static readonly IAnimal Null = new NullAnimal();

        private class NullAnimal : Animal
        {
            public override void MakeSound() { }
        }

        public abstract void MakeSound();
    }
}
