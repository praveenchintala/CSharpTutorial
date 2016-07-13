using System;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Walk();
            Person.Run();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string  Gender { get; set; }

        public int Age { get; set; }

        public void Walk()
        {
            Utils.Write("Keep Walking");
        }
        public static void Run()
        {
            Console.WriteLine("Running");
        }

        
    }
    static class Utils
    {
        public static void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    
    
}
