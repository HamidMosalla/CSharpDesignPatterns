using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Memento
    {
        public readonly Stack<string> StringStates;

        public Memento()
        {
            this.StringStates = new Stack<string>();
        }
    }
}
