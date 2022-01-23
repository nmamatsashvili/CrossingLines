using System;

namespace CrossingLines
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * TODO add collinear case
             * TODO add segment case
             */
            Point a = new Point(5, 1);
            Point b = new Point(4, 2);

            Point c = new Point(2, 1);
            Point d = new Point(5, 4);

            Console.WriteLine("Result");
            bool rst = PointCls.doIntersects(a, b, c, d);
            if(rst)
                Console.WriteLine("Those lines intersects");
            else
                Console.WriteLine("Those lines DOES NOT intersect");

        }
    }

    public struct Point {
        public float X { get; }
        public float Y { get; }
        public Point(float x, float y) {
            X = x; 
            Y = y;
        }
        public override string ToString() => $"({X}, {Y})";
    }
    public class PointCls {
        public static bool doIntersects(Point A, Point B, Point C, Point D) {
            Console.WriteLine("A: " + A.ToString());
            Console.WriteLine("B: " + B.ToString());
            Console.WriteLine("C: " + C.ToString());
            Console.WriteLine("D: " + D.ToString());
            float n = (B.Y - A.Y) / (B.X - A.X);
            Console.WriteLine("n - " + n.ToString());

            float m = (D.Y - C.Y) / (D.X - C.X);
            Console.WriteLine("m - " + m.ToString());
            if (m == n)
                return false;
            float intersectPoint_X = (n * A.X - m * C.X + C.Y - A.Y) / (n - m);

            float intersectPoint_Y = n * (intersectPoint_X - A.X) + A.Y;

            Console.WriteLine("intersect point X - " + intersectPoint_X.ToString());
            Console.WriteLine("intersect point Y - " + intersectPoint_Y.ToString());

            return true;
        }
    }
}
