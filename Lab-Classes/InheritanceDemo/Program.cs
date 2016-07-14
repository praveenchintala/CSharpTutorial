using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;
            i = 20;
            ClassB b = new ClassB("Sample");
            Console.Read();

            Console.WriteLine("Default Contrucrtor");
            ClassB b1 = new ClassB("Sample");


        }
    }
    class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("Default Contrucrtor");
        }
        public ClassA(string message)
        {
            Console.WriteLine("Constructor with {0} argumenbt", message);
        }
        public ClassA(int i)
        {
            Console.WriteLine("Print {0}x4 ={1}", i, i * 4);
        }
    }

    class ClassB : ClassA
    {
        public ClassB() : base("Hello")
        {
            Console.WriteLine("This is Class B");
        }
        public ClassB(string message) : base(10)
        {
            Console.WriteLine
                ("This is a new Constructor");

        }

    }

    class sample
    {
        public string name { get; set; }
        public int age { get; set; }
        public string prop1 { get; set; }
        public string porp2 { get; set; }
        public string prop3 { get; set; }



    }

}
