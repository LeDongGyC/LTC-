using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Car cars = new Car();
            Truck trucks = new Truck();
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Hiển thị danh sách car");
                Console.WriteLine("2. Hiển thị danh sách truck");
                Console.WriteLine("3. Hiển thị các xe có giá trong khoảng 100.000 đến 250.000");
                Console.WriteLine("4. Hiển thị các xe có năm sản xuất > 1990");
                Console.WriteLine("5. Gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm");
                Console.WriteLine("6. Hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất");
                Console.WriteLine("7. Hiển thị tên cty chủ quản của Truck");
                Console.WriteLine("0. Thoát");

                Console.Write("Nhập lựa chọn của bạn: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("List of Cars:");
                        foreach (var car in Car.GetAllCars())
                        {
                            Console.WriteLine($"Id:{car.Id}, Name:{car.Name}, Brand: {car.Brand}, Year: {car.Year}, Origin: {car.Origin}, Price: {car.Price}, Color: {car.Color}, Number of Seats: {car.NumberOfSeats}");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Danh sách truck:");
                        foreach (var truck in Truck.GetAllTruck())
                        {
                            Console.WriteLine($"Id:{truck.Id}, Name:{truck.Name}, Brand: {truck.Brand}, Year: {truck.Year}, Origin: {truck.Origin}, Price: {truck.Price}, Color: {truck.Color}, Load of Truck: {truck.LoadOfTruck}, Owner Company: {truck.OwnerCompany}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Các xe có giá trong khoảng 100.000 đến 250.000:");
                        foreach (var car in Car.FilterCarsByPrice())
                        {
                            Console.WriteLine($"Id:{car.Id}, Name:{car.Name}, Brand: {car.Brand}, Origin: {car.Origin}, Year: {car.Year}, Price: {car.Price}, Color: {car.Color}");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Các xe có năm sản xuất > 1990:");
                        foreach (var car in Car.FilterCarsByYear())
                        {
                            Console.WriteLine($"Id:{car.Id}, Name:{car.Name}, Brand: {car.Brand}, Origin: {car.Origin}, Year: {car.Year}, Price: {car.Price}, Color: {car.Color}");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm:");
                        Car.GroupCars();
                        break;
                    case "6":
                        Console.WriteLine("Danh sách Truck theo thứ tự năm sản xuất mới nhất:");
                        foreach (var truck in Truck.DisplayTrucksByNewestYear())
                        {
                            Console.WriteLine($"Id:{truck.Id}, Name:{truck.Name}, Brand: {truck.Brand}, Origin: {truck.Origin}, Year: {truck.Year}, Price: {truck.Price}, Color: {truck.Color}, Owner Company: {truck.OwnerCompany}");
                        }
                        break;
                    case "7":
                        Console.WriteLine("Tên công ty chủ quản của các Truck:");
                        Truck.DisplayTrucksWithOwnerCompany();
                        break;
                    case "0":
                        Console.WriteLine("Thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
