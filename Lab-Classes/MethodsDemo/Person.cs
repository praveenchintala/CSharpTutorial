using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Person
    {
        int _stepCount = 0;

        public void Walk()
        {
            _stepCount++;
        }

        public void ShowNumberOfSteps()
        {
            Console.WriteLine("Till now step count :{0}", _stepCount);
        }

        public void Walk(int steps)
        {
            _stepCount += steps;
        }

        public int GetRank()
        {
            return 1;
        }
        public void Run(int kms)
        {
            _stepCount += kms * 500;
        }

    }
}
