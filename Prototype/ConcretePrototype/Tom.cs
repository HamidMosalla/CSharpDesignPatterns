using Prototype.AbstractPrototype;

namespace Prototype.ConcretePrototype
{
    class Tom : IPerson
    {
        private string _name = "Tom";

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