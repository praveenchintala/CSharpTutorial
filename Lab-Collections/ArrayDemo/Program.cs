using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleDimensionArray array = new SingleDimensionArray();

            Console.WriteLine("This array has {0} dimension(s)", array.Numbers.Rank);
            for(int i=0;i< array.Numbers.Length;i++)
            {
                Console.WriteLine(array.Numbers[i]);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Printing String Array");
            foreach (string name in array.Names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------------------");

            MultiDimensionArray multiArray = new MultiDimensionArray();
            Console.WriteLine("This array has {0} dimension(s)", multiArray.Numbers.Rank);
            foreach (int num in multiArray.Numbers)
            {
                Console.WriteLine(num);
            }
         
            //Wait for user key before closing console
            Console.Read();



        }

       

        
        
    }
}
