using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
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
