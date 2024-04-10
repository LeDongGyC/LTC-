using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new efEntities())
            {
                var selectFiltered = from s in db.Students
                                     where s.Age >= 18 && s.Age <= 20 && s.DepartmentId == 1
                                     select s;
                foreach (var data in selectFiltered)
                {
                    Console.WriteLine($"Student Name: {data.Name}, Age: {data.Age}, Department: {data.Department.Name}");
                }
            }
            Console.ReadLine();
        }
    }
}
