using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public string Description { get; set; }

        public Employee() { }
        public Employee(string name,int age, int positionId, int departmentId, string description)
        {
            Name = name;
            Age = age;
            PositionId = positionId;
            DepartmentId = departmentId;
            Description = description;
        }
        public static List<Employee> GetEmployees() 
        {
            List<Employee> employees = new List<Employee>
            {
            new Employee { Name = "Trần Thị Bình", Age = 25, PositionId = 2, DepartmentId = 1, Description = "Lập trình huy viên tài năng chuyên sâu về ứng dụng tài chính." },
            new Employee { Name = "Lê Văn Cần", Age = 35, PositionId = 3, DepartmentId = 2, Description = "Kế toán viên chi tiết với chuyên môn về tài chính tiếp thị." },
            new Employee { Name = "Phạm Thị Duyên", Age = 28, PositionId = 4, DepartmentId = 3, Description = "Thiết kế sáng tạo huy với niềm đam mê tối ưu hóa quy trình hoạt động." },
            new Employee { Name = "Hoàng Văn Em", Age = 32, PositionId = 5, DepartmentId = 4, Description = "Nhân viên bán hàng năng động với khả năng xây dựng mối quan hệ khách hàng mạnh mẽ." },
            new Employee { Name = "Nguyễn Thị Phúc", Age = 27, PositionId = 6, DepartmentId = 5, Description = "Chuyên gia nhân sự có kỹ năng trong tuyển dụng tài năng và quan hệ lao động." },
            new Employee { Name = "Vũ Văn Giang", Age = 29, PositionId = 1, DepartmentId = 1, Description = "Quản lý đã chứng minh với sự tập trung vào chiến lược và phân tích tài chính." },
            new Employee { Name = "Trần Văn Hiếu", Age = 31, PositionId = 2, DepartmentId = 2, Description = "Lập trình viên sáng tạo với khả năng tiếp cận giải pháp công nghệ tiếp thị." },
            new Employee { Name = "Lê Thị Hoa", Age = 33, PositionId = 3, DepartmentId = 3, Description = "Kế toán viên giàu kinh nghiệm với khả năng tối ưu hóa tài chính hoạt động." },
            new Employee { Name = "Nguyễn Văn Khánh", Age = 26, PositionId = 4, DepartmentId = 4, Description = "Thiết kế đa năng cam kết nâng cao trải nghiệm dịch vụ khách hàng." },
            new Employee { Name = "Phạm Thị Liên", Age = 34, PositionId = 5, DepartmentId = 5, Description = "Nhân viên bán hàng có kết quả với nền tảng trong bán hàng CNTT." },
            new Employee { Name = "Hoàng Văn Mạnh", Age = 29, PositionId = 6, DepartmentId = 1, Description = "Chuyên viên nhân sự với chuyên môn trong tuyển dụng ngành tài chính." },
            new Employee { Name = "Lê Thị Ngọc", Age = 32, PositionId = 1, DepartmentId = 2, Description = "Quản lý chiến lược với tập trung vào tối ưu hóa chiến dịch tiếp thị." },
            new Employee { Name = "Trần Văn Huy", Age = 28, PositionId = 2, DepartmentId = 3, Description = "Lập trình viên cam kết tối ưu hóa hiệu suất hoạt động thông qua công nghệ." },
            new Employee { Name = "Nguyễn Thị Phương", Age = 30, PositionId = 3, DepartmentId = 4, Description = "Kế toán viên phân tích với niềm đam mê về các chỉ số dịch vụ khách hàng." },
            new Employee { Name = "Vũ Văn yết", Age = 27, PositionId = 4, DepartmentId = 5, Description = "Thiết kế sáng tạo chuyên sâu về thiết kế giao diện người dùng CNTT." },
            new Employee { Name = "Trần Thị Dung", Age = 31, PositionId = 5, DepartmentId = 1, Description = "Nhân viên bán hàng phong cách với tập trung vào bán hàng sản phẩm tài chính." },
            new Employee { Name = "Lê Văn Sĩ Huynh", Age = 33, PositionId = 6, DepartmentId = 2, Description = "Chuyên gia nhân sự cam kết hỗ trợ các nhóm tiếp thị trong quản lý tài năng." },
            new Employee { Name = "Nguyễn Thị Trinh", Age = 26, PositionId = 1, DepartmentId = 3, Description = "Quản lý năng động giàu kinh nghiệm trong việc tối ưu hóa quy trình hoạt động." },
            new Employee { Name = "Vũ Văn Đức", Age = 34, PositionId = 2, DepartmentId = 4, Description = "Lập trình viên sáng tạo cam kết nâng cao công nghệ dịch vụ khách hàng." }
            };
            return employees;
        }
    }
}
