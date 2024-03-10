using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Employee : Person
    {
        public string Degree { get; set; }
        public double Salary { get; set; } 
        public override void InputInformation()
        {
            base.InputInformation(); 

            Console.WriteLine("Enter Degree:");
            Degree = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            Salary = double.Parse(Console.ReadLine());
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation(); 

            Console.WriteLine($"Degree: {Degree}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
