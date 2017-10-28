using Bridge.Abstraction;
using Bridge.ImplementorAbstract;

namespace Bridge.AbstractionRefined
{
    public class ClientRepository : Repository
    {
        public override void AddObject(DataObject dataObject)
        {
            // Do repository specific work
            dataObject.Register();
        }

        public override void CopyObject(DataObject dataObject)
        {
            // Do repository specific work
            dataObject.Copy();
        }

        public override void RemoveObject(DataObject dataObject)
        {
            // Do repository specific work
            dataObject.Delete();
        }
    }
}
