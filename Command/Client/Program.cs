using System;
using Command.CommandInvoker;
using Command.Commands;
using Command.Receiver;

namespace Command.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string argument = Console.ReadLine();

            ISwitchable lamp = new Light();

            //Pass reference to the lamp instance to each command
            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);

            //Pass reference to instances of the Command objects to the switch
            Switch @switch = new Switch(switchClose, switchOpen);

            if (argument == "ON")
            {
                // Switch (the Invoker) will invoke Execute() on the command object.
                @switch.Close();
            }
            else if (argument == "OFF")
            {
                //Switch (the Invoker) will invoke the Execute() on the command object.
                @switch.Open();
            }
            else
            {
                Console.WriteLine("Argument \"ON\" or \"OFF\" is required.");
            }
        }
    }
}
