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

            /*
             More info: https://en.wikipedia.org/wiki/Command_pattern
             What problems can the Command design pattern solve?

            Coupling the invoker of a request to a particular request should be avoided.
            That is, hard-wired requests should be avoided.
            It should be possible to configure an object (that invokes a request) with a request.

            Implementing (hard-wiring) a request directly into a class is inflexible because
            it couples the class to a particular request at compile-time,
            which makes it impossible to specify a request at run-time.
             */

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
