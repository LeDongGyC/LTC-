using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Car : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public Car() { }
        public Car(int id,string name,string brand, int year, string origin, double price, string color, int numberOfSeats) : base(id,name,brand, origin, year, price, color)
        {
            NumberOfSeats = numberOfSeats;
        }
        private static List<Car> cars = new List<Car>
        {
            new Car(1,"Toyota Vios","Toyota", 2010, "Nhật Bản", 150000, "Đen", 4),
            new Car(2,"Honda City G","Honda", 2005, "Nhật Bản", 800000, "Trắng", 4),
            new Car(3,"Ford Territory","Ford", 1995, "Mỹ", 145000, "Xanh", 4),
            new Car(4,"Chevrolet Volt","Chevrolet", 2020, "Mỹ", 200000, "Đỏ", 4),
            new Car(5,"Nissan Kicks e-power","Nissan", 2015, "Nhật Bản", 180000, "Bạc", 4),
            new Car(6,"Toyota Raize","Toyota", 2022, "Nhật Bản", 420000, "Đen", 4),
            new Car(7,"Honda BR-V","Honda", 1998, "Nhật Bản", 320000, "Xanh", 4),
            new Car(8,"Ford Explorer","Ford", 2000, "Mỹ", 170000, "Đen", 4),
            new Car(9,"Chevrolet Spark","Chevrolet", 2018, "Mỹ", 240000, "Xanh", 4),
            new Car(10,"Nissan Almera","Nissan", 2008, "Nhật Bản", 130000, "Bạc", 4)
        };
        public static IEnumerable<Car> GetAllCars()
        {
            return cars;
        }
        public static IEnumerable<Car> FilterCarsByPrice()
        {
            return cars.Where(car => car.Price >= 100000 && car.Price <= 250000);
        }
        public static IEnumerable<Car> FilterCarsByYear()
        {
            return cars.Where(car => car.Year > 1990);
        }
        public static void GroupCars()
        {
            var groupedCars = cars
            .GroupBy(c => c.Brand)
            .Select(group => new
            {
                Brand = group.Key,
                TotalPrice = group.Sum(c => c.Price)
            });
            foreach (var group in groupedCars)
            {
                Console.WriteLine($"Brand: {group.Brand}, Total Price: {group.TotalPrice}");
            }
        }
    }
}
