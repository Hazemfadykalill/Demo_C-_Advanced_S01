using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C__Advanced_S01.Generic
{
    internal class Point:IComparable<Point>
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(Point? other)
        {
            if (other == null) return 1;
            if (X == other.X) return Y.CompareTo(other.Y);
            else return X.CompareTo(other.X);

        }

        public override string ToString()
        {
            return $" ( {X}, {Y} )";
        }
    }
}
