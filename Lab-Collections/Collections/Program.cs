using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            //ArrayList can accept any object
            arrList.Add(101);
            arrList.Add("Raju");
            arrList.Add(25000.02);
            arrList.Add(new Person { Name = "Sirisha", Age = 25 });

            Console.WriteLine("Printing ArrayList Contents");
            foreach (var item in arrList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-------------------------------");

            SortedList sortedList = new SortedList();
            sortedList.Add("a-107", new Person { Name = "Ravi", Age = 30 });
            sortedList.Add("a-105", new Person { Name = "Sirisha", Age = 24 });
            sortedList.Add("a-102", new Person { Name = "Prasanth", Age = 28 });
            sortedList.Add("a-101", new Person { Name = "Pooja", Age = 27 });
            sortedList.Add("a-103", new Person { Name = "Lokesh", Age = 32 });
            sortedList.Add("a-104", new Person { Name = "Anitha", Age = 25 });
            sortedList.Add("a-106", new Person { Name = "Ravi B", Age = 24 });

            Console.WriteLine("Priting Sorted List");
            
            for (int k = 0; k < sortedList.Keys.Count; k++)
            {
                //Get items based on keys
                Console.WriteLine(sortedList[sortedList.GetKey(k)].ToString());
            }
            Console.WriteLine("-------------------------------");

            //Wait for user key
            Console.Read();
        }


    }
}
