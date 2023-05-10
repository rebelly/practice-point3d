using System;
namespace ConsoleApp1
{
    

        class Point3d
    {
        private int x;
        private int y;
        private int z;
        private Point3d(int x, int y, int z)
        {
            this.y = y;
            this.x = x; 
            this.z = z; 
        }
        public static Point3d cool_class(int x, int y, int z)
        {
            if (x > 0 & x + y < z) return new Point3d(x, y, z);
            else return new Point3d(5, 15, 4);
        }
        public  static Point3d operator +(Point3d obj1, Point3d obj2)
        {
            return new Point3d(obj1.X + obj2.X, obj1.Y + obj2.Y, obj1.Z + obj2.Z);
        }
        public static Point3d operator -(Point3d obj1, Point3d obj2)
        {
            return new Point3d(obj1.X - obj2.X, obj1.Y- obj2.Y, obj1.Z - obj2.Z);
        }
        public static Point3d operator ++(Point3d obj1)
        {
            return new Point3d(obj1.X + 1, obj1.Y + 1, obj1.Z + 1);
        }
        public static Point3d operator --(Point3d obj1)
        {
            return new Point3d(obj1.X -1, obj1.Y -1, obj1.Z-1);
        }
        public static bool operator >=(Point3d obj1, Point3d obj2)
        {
            return (obj1.X>= obj2.X) && (obj1.Y >= obj2.Y) && (obj1.Z >= obj2.Z);
        }
        public static bool operator <=(Point3d obj1, Point3d obj2)
        {
            return (obj1.X <= obj2.X) && (obj1.Y <= obj2.Y) && (obj1.Z <= obj2.Z);
        }
        public static bool operator &(Point3d obj1, Point3d obj2)
        {
            return ((obj1.X == obj2.X) && (obj1.Y != obj2.Y) && (obj1.Z > 0 )&&(obj2.Z > 0)); 
        } // на одной прямой, разная высота, в верхней части трехмерной плоскости
        public static bool operator |(Point3d obj1, Point3d obj2)
        {
            return ((obj1.X == obj2.X) || (obj1.Y == obj1.Y)); // либо на одной высоте либо на одной широте (х и у)
        } 
        public static bool operator true(Point3d obj1)
        {
            return obj1.X > 0 && obj1.X + obj1.Y > obj1.Z; // в правой часте и сумма координат двухмерной плоскости больше 
        }
        public static bool operator false(Point3d obj1)
        {

            return obj1.X < 0 || obj1.X + obj1.Y < obj1.Z;
        }
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public int Z
        {
            get { return z; }
        }

    }
    class Program
        
    {
        static void Main()
        {
            Point3d p1, p2;
            p1 = Point3d.cool_class(5, 10, 13);
            p2 = Point3d.cool_class(5, 10, 11);
            if (p1) Console.WriteLine("Первый объект находится в 1 и 2 плоскости, сумма его двумернеых координат больше трехмерной");
            if (p2) Console.WriteLine("Второй объект находится в 1 и 2 плоскости, сумма его двумернеых координат больше трехмерной");
            Console.WriteLine();
            if (p1 & p2) Console.WriteLine("Оба объекта находятся на одной прямой по оХ, на разной ширине по Оу и в верхней части трехмерной плоскости");
            Console.WriteLine("Сумма двух точек:");
            Console.WriteLine($"Новая точка с координатами: {(p1 + p2).X}, {(p1 + p2).Y}, {(p1 + p2).Z}");
            Console.WriteLine();
            Console.WriteLine("Разность двух точек");
            Console.WriteLine($"Новая точка с координатами: {(p1 - p2).X}, {(p1 - p2).Y}, {(p1 - p2).Z}");
            Console.WriteLine();
            if (p1 >=p2) Console.WriteLine("Первая точка больше либо равна второй");
            if (p1 <= p2) Console.WriteLine("Первая точка меньше либо равна второй");

        }

    }
}
