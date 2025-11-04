using Squares.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares.Domain.Entities
{
    public class Point
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }
    }
}
