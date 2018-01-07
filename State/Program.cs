using System;
using State.Refactored.StateMachineContext;

namespace State
{
    static class Program
    {
        public static void Main()
        {
            /*https://stackoverflow.com/a/30424503/1650277
             What problems can the State design pattern solve?

            An object should change its behavior when its internal state changes.
            State-specific behavior should be defined independently.
            That is, new states should be added and the behavior of
            existing states should be changed independently.

            Implementing state-specific behavior directly within a class is inflexible because
            it commits the class to a particular behavior and makes it impossible to add a new state
            or change the behavior of an existing state later independently from (without changing) the class.
             * 
             * Strategy pattern vs State pattern
            States store a reference to the context object that contains them. Strategies do not.
            States are allowed to replace themselves (IE: to change the state of the context object to something else), while Strategies are not.
            Strategies are passed to the context object as parameters, while States are created by the context object itself.
            Strategies only handle a single, specific task, while States provide the underlying implementation for everything (or most everything) the context object does.
             */

            LegacyTest();
            Console.WriteLine();
            var gumballmachine = new GumballMachine(5);
            gumballmachine.InsertQuarter();
            gumballmachine.TurnCrank();
            gumballmachine.InsertQuarter();
            gumballmachine.TurnCrank();
        }

        private static void LegacyTest()
        {
            var machine = new Legacy.GumballMachine(2);
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.EjectQuarter();
            machine.InsertQuarter();
        }
    }
}
