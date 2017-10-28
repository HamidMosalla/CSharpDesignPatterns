using System;
using System.Collections.Generic;
using System.Text;
using Command.Commands;

namespace Command.CommandInvoker
{
    public class Switch
    {
        readonly ICommand _closedCommand;
        readonly ICommand _openedCommand;

        public Switch(ICommand closedCommand, ICommand openedCommand)
        {
            this._closedCommand = closedCommand;
            this._openedCommand = openedCommand;
        }

        //close the circuit/power on
        public void Close()
        {
            this._closedCommand.Execute();
        }

        //open the circuit/power off
        public void Open()
        {
            this._openedCommand.Execute();
        }
    }
}
