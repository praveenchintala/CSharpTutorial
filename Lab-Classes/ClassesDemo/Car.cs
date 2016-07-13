using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Car
    {
        //Private Member or Field
        private int _modelNumber;

        public string ModelName { get; set; }

        //Public Property
        public int ModelNumber
        {
            get
            {
                return _modelNumber;
            }
            set
            {
                _modelNumber = value;
            }
        }

        public string PrintModel()
        {
            return this.ModelName;
        }

        private string DisplayNumber()
        {
            return this.ModelNumber.ToString();

        }


        public Car()
        {
            _modelNumber = 100;
        }
        public Car(int modelNumber)
        {
            _modelNumber = modelNumber;

        }

        


    }
}
