namespace Composite.ComponentObject
{
    internal abstract class Component
    {
        public string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
    }
}