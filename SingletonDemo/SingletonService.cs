using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    sealed class SingletonService
    {
        private SingletonService() { }
        private static SingletonService _instance;
        public static readonly object _instanceLock = new object();
        public int Id { get; private set; }

        public static SingletonService Instance(int id)
        {
            if(_instance == null)
            {
                lock(_instanceLock)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonService();
                        _instance.Id = id;
                    }
                }                
            }

            Console.WriteLine("Returning Instance ID: {0}", _instance.Id);
            return _instance;
        }
    }
}
