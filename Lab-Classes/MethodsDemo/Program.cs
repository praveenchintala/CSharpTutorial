using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Walk();
            p.Walk();
            p.Walk();
            p.Walk(10);
            p.ShowNumberOfSteps();

            p.Run(5);
            p.ShowNumberOfSteps();

            Console.Read();
        }
    }
}
