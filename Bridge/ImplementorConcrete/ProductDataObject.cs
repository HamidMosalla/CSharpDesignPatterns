using System;
using System.Collections.Generic;
using System.Text;
using Bridge.ImplementorAbstract;

namespace Bridge.ImplementorConcrete
{
    public class ProductDataObject : DataObject
    {
        public override void Register()
        {
            Console.WriteLine("ProductDataObject was registered");
        }

        public override DataObject Copy()
        {
            Console.WriteLine("ProductDataObject was copied");
            return new ProductDataObject();
        }

        public override void Delete()
        {
            Console.WriteLine("ProductDataObject was deleted");
        }
    }
}
