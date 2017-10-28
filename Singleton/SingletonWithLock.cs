using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class SingletonWithLock
    {
        private static SingletonWithLock instance = null;
        private static readonly object padlock = new object();

        SingletonWithLock()
        {
        }

        public static SingletonWithLock Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonWithLock();
                    }
                    return instance;
                }
            }
        }
    }
}
