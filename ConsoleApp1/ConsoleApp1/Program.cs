using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 19, 10, 20, 40, 40 };
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
