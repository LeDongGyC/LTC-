using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static List<Employee> employees = new List<Employee>();
        static int customerCount = 0;
        static int employeeCount = 0;

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Add Employee");
                Console.WriteLine("3. Display Customers (Ordered by Age)");
                Console.WriteLine("4. Display Employees (Ordered by Salary)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        AddEmployee();
                        break;
                    case 3:
                        DisplayCustomersOrderedByAge();
                        break;
                    case 4:
                        DisplayEmployeesOrderedBySalary();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            } while (choice != 0);
        }

        static void AddCustomer()
        {
            customerCount++;
            Customer customer = new Customer();
            Console.WriteLine($"Enter Customer {customerCount} Information:");
            customer.InputInformation();
            customers.Add(customer);
            Console.WriteLine("Customer added successfully.");
            
        }

        static void AddEmployee()
        {
            employeeCount++;
            Employee employee = new Employee();
            Console.WriteLine($"Enter Employee {employeeCount} Information:");
            employee.InputInformation();
            employees.Add(employee);
            Console.WriteLine("Employee added successfully.");
        }

        static void DisplayCustomersOrderedByAge()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers to display.");
                return;
            }

            customers.Sort((x, y) => x.Age.CompareTo(y.Age));
            Console.WriteLine("Customers ordered by age:");
            foreach (Customer customer in customers)
            {
                customer.DisplayInformation();                
            }
            Console.ReadLine();
        }

        static void DisplayEmployeesOrderedBySalary()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees to display.");
                return;
            }

            employees.Sort((x, y) => y.Salary.CompareTo(x.Salary));
            Console.WriteLine("Employees ordered by salary:");
            foreach (Employee employee in employees)
            {
                employee.DisplayInformation();               
            }
            Console.ReadLine();
        }
    }
}
