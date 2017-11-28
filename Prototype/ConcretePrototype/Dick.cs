using Prototype.AbstractPrototype;

namespace Prototype.ConcretePrototype
{
    class Dick : IPerson
    {
        private string _name = "Dick";

        public IPerson Clone()
        {
            //shallow copy
            return (IPerson)this.MemberwiseClone();

            //deep copy
            //return (IPerson)this.Clone();
        }

        public override string ToString()
        {
            return _name;
        }
    }
}