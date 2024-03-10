using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FullName = "Phạm Lê Đông", Age = 25, Gender = 1, Salary = 25000000 },
            new Employee { Id = 2,FullName = "Phạm Văn Xuân", Age = 22, Gender = 1, Salary = 18000000 },
            new Employee { Id =3, FullName = "Nguyễn Thị Tuyết", Age = 30, Gender = 0, Salary = 22000000 },
            new Employee { Id =4, FullName = "Đặng Thu Trà", Age = 33, Gender = 0, Salary = 17000000 } 
        };
            Console.WriteLine("Danh sách nhân viên ban đầu:");
            PrintEmployees(employees);

            var ageFilteredEmployees = employees.Where(e => e.Age >= 17 && e.Age <= 30);
            Console.WriteLine("\nDanh sách nhân viên tuổi từ 17 đến 30:");
            PrintEmployees(ageFilteredEmployees);

            var maleEmployees = employees.Where(e => e.Gender == 1);
            Console.WriteLine("\nDanh sách nhân viên là nam:");
            PrintEmployees(maleEmployees);

            var highSalaryEmployees = employees.Where(e => e.Salary > 20000000);
            Console.WriteLine("\nDanh sách nhân viên có lương cao hơn 20 triệu:");
            PrintEmployees(highSalaryEmployees);

            Console.ReadLine();
        }
        static void PrintEmployees(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                string genderString = employee.Gender == 1 ? "Nam" : "Nữ";
                Console.WriteLine($"Id: {employee.Id}, Tên: {employee.FullName}, Tuổi: {employee.Age}, Giới tính: {genderString}, Lương: {employee.Salary}");
            }
        }
    }
}
