using Prototype.AbstractPrototype;

namespace Prototype.ConcretePrototype
{
    class Dick : IPerson
    {
        private string _name = "Dick";

        public IPerson Clone()
        {
            return (IPerson)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return _name;
        }
    }
}