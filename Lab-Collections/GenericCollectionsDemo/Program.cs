using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            list.Add(new Person { Name = "Ravi", Age = 30 });
            list.Add(new Person { Name = "Sirisha", Age = 24 });
            list.Add(new Person { Name = "Prasanth", Age = 28 });
            list.Add(new Person { Name = "Pooja", Age = 27 });
            list.Add(new Person { Name = "Lokesh", Age = 32 });
            list.Add(new Person { Name = "Anitha", Age = 25 });
            list.Add(new Person { Name = "Ravi B", Age = 24 });

            Console.WriteLine("Printing Generic Collection Items");
            foreach (var item in list)
            {
                Console.WriteLine(item.Name +" / "+ item.Age);
            }

            Console.WriteLine("------------------------");

            Queue<Person> q = new Queue<Person>();
            q.Enqueue(new Person { Name = "Ravi", Age = 30 });
            q.Enqueue(new Person { Name = "Sirisha", Age = 24 });
            q.Enqueue(new Person { Name = "Prasanth", Age = 28 });
            //Ravi Left from the queue
            q.Dequeue();
            q.Enqueue(new Person { Name = "Pooja", Age = 27 });
            q.Enqueue(new Person { Name = "Lokesh", Age = 32 });
            q.Enqueue(new Person { Name = "Anitha", Age = 25 });
            // Sirisha Left from the queue
            q.Dequeue();
            q.Enqueue(new Person { Name = "Ravi B", Age = 24 });

            Console.WriteLine("Printing Persons in Queue");
            foreach (var person in q)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("------------------------");


            Console.Read();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Age);
        }
    }
}
