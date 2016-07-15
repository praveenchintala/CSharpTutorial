using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class MultiDimensionArray
    {
        int[,] arrList = new int[3, 2];

        public int[,] Numbers
        {
            get
            {
                return arrList;
            }
        }

        /// <summary>
        /// </summary>
        public MultiDimensionArray()
        {
            /// Fill Array 

            //First Row
            arrList[0,0] = 100;
            arrList[0,1] = 101;

            //Second Row
            arrList[1,0] = 200;
            arrList[1,1] = 201;

            //Third Row
            arrList[2, 0] = 300;
            arrList[2, 1] = 301;

        }
    }
}
