using Prototype.AbstractPrototype;

namespace Prototype.ConcretePrototype
{
    class Harry : IPerson
    {
        private string _name = "Harry";

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