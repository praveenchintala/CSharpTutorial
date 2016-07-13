using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b = new Building();
            b.BlockB();
            b.BlockA();
        }
    }

    partial class Building
    {
        public void BlockA()
        {
            Console.WriteLine("Block A");
            
        }


    }
}
