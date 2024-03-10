using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Truck : Vehicle
    {
        public string OwnerCompany { get; set; }
        public double LoadOfTruck { get; set; }
        public Truck() { }
        public Truck(int id,string name, string brand, string origin, int year, double price, string color, string ownerCompany, double loadOfTruck)
        : base(id,name, brand, origin, year, price, color)
        {
            OwnerCompany = ownerCompany;
            LoadOfTruck = loadOfTruck;
        }
        private static List<Truck> trucks = new List<Truck>
        {
            new Truck(1,"HINO MOTORS","HINO", "Japan", 2012, 971000000, "Black", "Hino Trucking", 10),
            new Truck(2,"ISUZU MOTORS","ISUZU", "Japan", 2015, 988800000, "White", "Isuzu Cargo", 15),
            new Truck(3,"HYNDAI MOTORS","HYNDAI", "Korean", 2010, 1088800000, "Blue", "Hyndai Transport", 12),
            new Truck(4,"FUSO MOTORS","FUSO", "Japan", 2018, 891000000, "Silver", "Fuso Logistics", 20),
            new Truck(5,"Daewoo MOTORS","Daewoo", "1258800000", 2019, 200000, "Red", "Mercedes Freight", 18)
        };
        public static IEnumerable<Truck> GetAllTruck()
        {
            return trucks;
        }
        public static IEnumerable<Truck> DisplayTrucksByNewestYear()
        {
            return trucks.OrderByDescending(truck => truck.Year);
        }

        public static void DisplayTrucksWithOwnerCompany()
        {
            foreach (var truck in trucks)
            {
                Console.WriteLine($"Id: {truck.Id}, Name: {truck.Name}, Brand: {truck.Brand}, Owner Company: {truck.OwnerCompany}");
            }
        }
    }
}
