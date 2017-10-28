using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.ImplementorAbstract
{
    public abstract class DataObject
    {
        public abstract void Register();
        public abstract DataObject Copy();
        public abstract void Delete();
    }
}
