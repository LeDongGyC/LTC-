using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Department() { }
        public Department(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public static List<Department> GenerateDepartments()
        {
            List<Department> departments = new List<Department>
        {
            new Department(1, "Finance", "Financecccccccc"),
            new Department(2, "Marketing", "Marketing số 1 vn"),
            new Department(3, "Operations", "Anh thợ may mắn"),
            new Department(4, "Customer Service", "Khách tự sửa"),
            new Department(5, "IT", "Lương nghìn đô la làng"),          
        };

            return departments;
        }
    }
}
