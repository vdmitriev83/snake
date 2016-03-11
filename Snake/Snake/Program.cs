using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1;
            Func1(x);
            Console.WriteLine("Func1 x=" + x);

            Point p1 = new Point(3, 5, '&');
            Move(p1,10,10);
            Console.WriteLine("Point p1=(" + p1.x+","+p1.y+")");

            Console.ReadLine();
        }

        static void Func1(int x)
        {
            x = x + 1;
        }

        static void Func2(int x)
        {
            x = x + 2;
        }

        static void Move(Point p, int dx, int dy)
        {
            p.x += dx;
            p.y += dy;
        }
    }
}
