using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Position() { }
        public Position(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public static List<Position> GeneratePositions()
        {
            List<Position> positions = new List<Position>
        {
            new Position(1, "Manager", "Managerrrrrrrr"),
            new Position(2, "Developer", "Đây là Dev"),
            new Position(3, "Accountant", "Accountant abcxzy"),
            new Position(4, "Designer", "Pro Designer"),
            new Position(5, "Sales", "Đa cấp đây"),
            new Position(6, "HR", "Ở đây không tuyển"),
        };

            return positions;
        }
    }
}
