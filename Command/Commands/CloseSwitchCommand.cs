using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Command.Receiver;

namespace Command.Commands
{
    public class CloseSwitchCommand : ICommand
    {
        private ISwitchable _switchable;

        public CloseSwitchCommand(ISwitchable switchable)
        {
            _switchable = switchable;
        }

        public void Execute()
        {
            _switchable.PowerOn();
        }
    }
}
