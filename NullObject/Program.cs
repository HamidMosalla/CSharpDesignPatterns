using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * More info: https://en.wikipedia.org/wiki/Null_object_pattern
            * What problems can the Memento design pattern solve?
            In most object-oriented languages, such as Java or C#, references may be null.
            These references need to be checked to ensure they are not null before invoking any methods,
            because methods typically cannot be invoked on null references.

           The Objective-C language takes another approach to this problem and does nothing when sending a message to nil;
           if a return value is expected, nil (for objects), 0 (for numeric values), NO (for BOOL values),
           or a struct (for struct types) with all its members initialised 
           to null/0/NO/zero-initialised struct is returned.[2]
            */

            //Remember null object is an anti pattern: https://stackoverflow.com/questions/1178399/how-do-i-create-a-null-object-in-c-sharp
            IAnimal dog = new Dog();
            dog.MakeSound();

           // replace Animal.Null with null and you'll get an exception
            IAnimal unknown = Animal.Null; 
            unknown.MakeSound();
        }
    }
}
