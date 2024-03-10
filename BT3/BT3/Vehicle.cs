using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Origin { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public Vehicle() { }
        public Vehicle(int id,string name, string brand,string origin, int year, double price, string color)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Origin = origin;
            Year = year;
            Price = price;
            Color = color;
        }
    }

}
