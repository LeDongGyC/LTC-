using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 5, 19, 10, 20, 40, 40 };
            int maxIndex = myArray.Length - 1;
            for (int idx = 0; idx <= maxIndex; idx++)
            {
                Console.WriteLine(myArray[idx]);
            }
        }
    }
}
