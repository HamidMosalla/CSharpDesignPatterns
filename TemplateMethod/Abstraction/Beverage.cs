using System;

namespace TemplateMethod.Abstraction
{
    public abstract class Beverage
    {
        protected int _sugar;

        public void Prepare()
        {
            Boil();
            Brew();
            Pour();
            if (WantsCondiments)
                AddCondiments();

        }

        public bool WantsCondiments { private get; set; }

        private void Boil()
        {
            Console.WriteLine("Boling Water");
        }

        protected abstract void Brew();

        private void Pour()
        {
            Console.WriteLine("Pouring in Cup");
        }

        protected abstract void AddCondiments();

        public int AddSugar { get; set; }

        protected void Sugar() { }
    }
}