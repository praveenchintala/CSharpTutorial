using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEmployeeList list = new MyEmployeeList();

            Console.WriteLine("Looping through custom collection");
            //We can only use foreach on a type that implemented IEnumerable
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }

        class Employee
        {
            public int EmpId { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return string.Format("{0}-{1}", EmpId, Name);
            }
        }

        class MyEmployeeList : IEnumerable
        {

            ArrayList list = new ArrayList();
            public MyEmployeeList()
            {
                list.Add(new Employee { Name = "Ravi",EmpId=10001 });
                list.Add(new Employee { Name = "Keerthi", EmpId = 10002 });
                list.Add(new Employee { Name = "Prasanth", EmpId = 10003 });
                list.Add(new Employee { Name = "Rajesh", EmpId = 10004 });
            }

            public IEnumerator GetEnumerator()
            {
                //Calling ArrayLIst Enumerator
                return list.GetEnumerator();
            }
        }
    }
}
