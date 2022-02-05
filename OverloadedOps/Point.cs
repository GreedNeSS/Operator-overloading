using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"[{X}, {Y}]";
        public override bool Equals(object obj) => obj?.ToString() == this.ToString();
        public override int GetHashCode() => this.ToString().GetHashCode();

        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y)
            {
                return 1;
            }
            else if (this.X < other.X && this.Y < other.Y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static Point operator +(Point point1, Point point2) =>
            new Point(point1.X + point2.X, point1.Y + point2.Y);

        public static Point operator -(Point point1, Point point2) =>
            new Point(point1.X - point2.X, point1.Y - point2.Y);

        public static Point operator +(int change, Point point2) =>
            new Point(change + point2.X, change + point2.Y);

        public static Point operator +(Point point1, int change) =>
            new Point(change + point1.X, change + point1.Y);

        public static Point operator -(int change, Point point2) =>
            new Point(change - point2.X, change - point2.Y);

        public static Point operator -(Point point1, int change) =>
            new Point(point1.X - change, point1.Y - change);

        public static Point operator ++(Point point) =>
            new Point(point.X + 1, point.Y + 1);

        public static Point operator --(Point point) =>
            new Point(point.X - 1, point.Y - 1);

        public static bool operator ==(Point point1, Point point2) =>
            point1.Equals(point2);

        public static bool operator !=(Point point1, Point point2) =>
            !point1.Equals(point2);

        public static bool operator <(Point p1, Point p2) => p1.CompareTo(p2) < 0;

        public static bool operator >(Point p1, Point p2) => p1.CompareTo(p2) > 0;

        public static bool operator <=(Point p1, Point p2) => p1.CompareTo(p2) <= 0;

        public static bool operator >=(Point p1, Point p2) => p1.CompareTo(p2) >= 0;
    }
}
