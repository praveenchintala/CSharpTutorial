using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Employee { Name = "Ravi", EmpId = 100011 });
            list.Add(new Employee { Name = "Keerthi", EmpId = 10004 });
            list.Add(new Employee { Name = "Prasanth", EmpId = 10002 });
            list.Add(new Employee { Name = "Rajesh", EmpId = 10009 });

            //Calling Sorting Method
            list.Sort();
            Console.WriteLine("Writing an EMployees List sorted based on EmpId");


            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());

            }
        }

        class Employee: IComparable
        {
            public int EmpId { get; set; }
            public string Name { get; set; }

            public int CompareTo(object obj)
            {
                
                return EmpId.CompareTo((obj as Employee).EmpId);
            }

            public override string ToString()
            {
                return string.Format("{0}-{1}", EmpId, Name);
            }
        }

    }
}
