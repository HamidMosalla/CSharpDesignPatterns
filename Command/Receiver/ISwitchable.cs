using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Receiver
{
    public interface ISwitchable
    {
        void PowerOn();
        void PowerOff();
    }
}
