using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class GenericFactory<T> where T : new()
    {
        public T CreateObject()
        {
            return new T();
        }
    }
}
