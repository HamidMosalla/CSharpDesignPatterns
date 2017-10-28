using System;
using System.Collections.Generic;
using System.Text;
using Bridge.ImplementorAbstract;

namespace Bridge.Abstraction
{
    public abstract class Repository
    {
        public abstract void AddObject(DataObject dataObject);
        public abstract void CopyObject(DataObject dataObject);
        public abstract void RemoveObject(DataObject dataObject);

        public void SaveChanges()
        {
            Console.WriteLine("Changes were saved");
        }
    }
}
