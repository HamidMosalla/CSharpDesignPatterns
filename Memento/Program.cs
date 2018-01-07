using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * More info: https://en.wikipedia.org/wiki/Memento_pattern
             What problems can the Memento design pattern solve?

                The internal state of an object should be saved externally so that the object can be restored to this state later.
                The object's encapsulation must not be violated.

            The problem is that a well designed object is encapsulated so that its representation (data structure)
            is hidden inside the object and can't be accessed from outside the object.
                         */

            var fileManager = new OriginalObject("State1");
            fileManager.FileState = "State2";
            fileManager.FileState = "State3";
            fileManager.FileState = "State4";

            Console.WriteLine($"First value {fileManager.FileState}");
            fileManager.Revert();
            Console.WriteLine($"After first revert {fileManager.FileState}");
            fileManager.Revert();
            Console.WriteLine($"After second revert {fileManager.FileState}");

        }
    }
}
