using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice.Creational_patterns;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.GetObject();
            s.Print();
            Singleton s2 = Singleton.GetObject();
            s.Print();
            Singleton s3 = Singleton.GetObject();
            s.Print();
            Console.ReadLine();
        }
    }
}
