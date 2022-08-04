using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("If you need the area of the circle, enter the Radius");
            int r = int.Parse (Console.ReadLine());
            Console.WriteLine("The area of the circle=" + Area(r));
                Console.WriteLine("Enter width and length if you want the area of the rectangle");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of a rectangle="+Area(a,b));
            Console.WriteLine("If you want to find the complete surface area of a rectangular parallelepiped, fold 3 sides");
            int f = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Complete surface area of a rectangular parallelepiped="+Area(f,d,c));
            Console.WriteLine("Enter the numbers for the area of the inscribed circle of the triangle,enter the most recent radius");
            int q = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of a circle inscribed in a triangle="+Area(q, w, e,t));
        }
        static int Area(int r)
        {
            int p = 3;
            return p * r * r;
        }
        static int Area (int a, int b)  
        {
            return a * b;
        }
        static int Area(int f, int d, int c)
        {
            return 2 * (f * d + f * c + d * c);
        }
        static int Area(int q, int w, int e,int t)
        {
            int p = (q + w + e) / 2;
            return p * t;
        }
    }
}
