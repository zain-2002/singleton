using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practice.Creational_patterns
{
    class Singleton
    {
        public static Singleton a;
        public static int objcount = 0;
        private Singleton()
        {
        }
        public static Singleton GetObject()
        {
            if (a == null)
            {
                a= new Singleton();
                objcount += 1;
            }
            return a;
        }
        public void Print()
        {
            Console.WriteLine("object created the times:"+objcount);
        }
    }
}
