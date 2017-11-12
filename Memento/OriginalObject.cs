using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class OriginalObject
    {
        private readonly Memento _memento;

        public string FileState
        {
            get { return _memento.StringStates.Peek(); }
            set => _memento.StringStates.Push(value);
        }

        public OriginalObject(string str)
        {
            _memento = new Memento();
            this._memento.StringStates.Push(str);
        }

        public void Revert()
        {
            _memento.StringStates.Pop();
        }
    }
}
