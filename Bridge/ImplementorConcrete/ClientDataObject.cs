using System;
using System.Collections.Generic;
using System.Text;
using Bridge.ImplementorAbstract;

namespace Bridge.ImplementorConcrete
{
    public class ClientDataObject : DataObject
    {
        public override void Register()
        {
            Console.WriteLine("ClientDataObject was registered");
        }

        public override DataObject Copy()
        {
            Console.WriteLine("ClientDataObject was copied");
            return new ClientDataObject();
        }

        public override void Delete()
        {
            Console.WriteLine("ClientDataObject was deleted");
        }
    }
}
