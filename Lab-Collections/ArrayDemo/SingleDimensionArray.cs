using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class SingleDimensionArray
    {
        //Fixed Length
        int[] numbers = new int[5] { 100, 200, 300, 400, 500 };
        string[] names = new string[] { "Ravi", "Sandip", "Prasanth", "Anjali", "Keerthi" };

        public int[] Numbers
        {
            get
            {
                return numbers;
            }
        }
        public string[] Names
        {
            get
            {
                return names;
            }
        }


    }
}
