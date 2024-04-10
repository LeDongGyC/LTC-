using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Employee> employees = Employee.GetEmployees();
            List<Position> positions = Position.GeneratePositions();
            List<Department> departments = Department.GenerateDepartments();
            Console.WriteLine("Nhập thông tin tìm kiếm (nhấn Enter để bỏ qua mục đó):");
            Console.Write("Nhập Keyword tìm kiếm: ");
            string textSearch = Console.ReadLine();
            Console.Write("Tìm theo tuổi từ: ");
            int fromAge = int.TryParse(Console.ReadLine(), out int fromAgeResult) ? fromAgeResult : 0;
            Console.Write("Tìm theo tuổi đến: ");
            int toAge = int.TryParse(Console.ReadLine(), out int toAgeResult) ? toAgeResult : int.MaxValue;
            Console.Write("Tìm theo vị trí: ");
            int positionIdSearch = int.TryParse(Console.ReadLine(), out int positionIdResult) ? positionIdResult : 0;
            Console.Write("Tìm theo phòng ban: ");
            int departmentIdSearch = int.TryParse(Console.ReadLine(), out int departmentIdResult) ? departmentIdResult : 0;

            string demo = "Đức";
            var result = from emp in employees
                         where emp.Name.Contains(demo)
                         select emp;

            var query = from emp in employees
                        join pos in positions on emp.PositionId equals pos.Id
                        join dept in departments on emp.DepartmentId equals dept.Id
                        where (string.IsNullOrEmpty(textSearch) || emp.Name.ToLower().Contains(textSearch.ToLower()) || pos.Description.Contains(textSearch) || dept.Description.Contains(textSearch)) &&
                              (emp.Age >= fromAge && emp.Age <= toAge) &&
                              (positionIdSearch == 0 || emp.PositionId == positionIdSearch) &&
                              (departmentIdSearch == 0 || emp.DepartmentId == departmentIdSearch)
                        select new
                        {
                            emp.Name,
                            emp.Age,
                            Position = pos.Name,
                            Department = dept.Name
                        };

            Console.WriteLine("\nKết quả tìm kiếm:");
            foreach (var employee in query)
            {
                Console.WriteLine($"Tên: {employee.Name}, Tuổi: {employee.Age}, Vị trí: {employee.Position}, Phòng ban: {employee.Department}");
            }

            /*Console.WriteLine("Kết quả tìm kiếm 222:");
            foreach (var employee in result)
            {
                Console.WriteLine($"Tên: {employee.Name}, Tuổi: {employee.Age}, Mô tả: {employee.Description}");
            }*/
            Console.ReadLine();
        }
    }
}
