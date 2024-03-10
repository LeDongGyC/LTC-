using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Person() { }
        public Person(string name, string address, string email, string phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }
        public virtual void InputInformation()
        {
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            Address = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            PhoneNumber = Console.ReadLine();

        }
        public virtual void DisplayInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
    }
}
