using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class SingletonWithoutLock
    {
        private static readonly SingletonWithoutLock instance = new SingletonWithoutLock();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonWithoutLock()
        {
        }

        private SingletonWithoutLock()
        {
        }

        public static SingletonWithoutLock Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
