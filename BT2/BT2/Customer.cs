using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Customer : Person
    {
        public string TypeCustomer { get; set; }
        public string Age { get; set; }
        public override void InputInformation()
        {
            base.InputInformation();

            Console.WriteLine("Enter Age:");
            Age = Console.ReadLine();

            Console.WriteLine("Enter Customer Type:");
            TypeCustomer = Console.ReadLine();
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Age: {Age}");

            Console.WriteLine($"Customer Type: {TypeCustomer}");
        }
    }

}
