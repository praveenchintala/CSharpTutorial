using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager manager = new Manager();

        }

        
        class Person
        {
            public Person()
            {
                Console.WriteLine("Person Invoked");
            }
            ~Person()
            {
                Console.WriteLine("Person Destroyed");
            }
        }

        class Employee : Person
        {
            public Employee()
            {
                Console.WriteLine("Employee Executed");
            }

            ~Employee()
            {
                Console.WriteLine("Employee Destroyed");
            }
        }

        class Manager: Employee
        {
            public Manager()
            {
                Console.WriteLine("Manager Executed");
            }

            ~Manager()
            {
                Console.WriteLine("Manager Destroyed");
            }
        }
    }
}
