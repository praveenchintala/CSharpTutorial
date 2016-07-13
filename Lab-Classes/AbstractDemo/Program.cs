using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ravi = new Employee();
            ravi.Work();
        }
    }

    abstract class Person
    {
       public abstract void Work();
       public void Eat()
        {
            Console.WriteLine("Working");
        }

        protected abstract void Meeting();
    }
    class Employee : Person
    {
        public override void Work()
        {
            Console.WriteLine("I work from 9AM to 5PM");
        }

        protected override void Meeting()
        {
            Console.WriteLine("Attending Meeting");
        }
    }
}
