using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.DesignPatterns
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _raceLock = new object();

        private Singleton()
        {
            //_instance = new Singleton();
        }

        public static Singleton getInstance
        {
            get
            {
                lock (_raceLock)
                {
                    if (_instance == null)
                        _instance = new Singleton();
                }
                return _instance;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine("Singleton Says : " + message);
        }
    }

    public sealed class TSingleton
    {
        static readonly TSingleton instance;

        // Thread safe as well
        static TSingleton()
        {
            /*  This method marks a static method to induce lazy
             *  initialization
             * */
            instance = new TSingleton();
        }

        TSingleton() { }

        public static TSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine("Singleton Says : " + message);
        }
    }
}
