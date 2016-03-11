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
            
            Point p1 = new Point(3,5,'&' );
            //p1.Draw();

            Point p2 = new Point(10, 2, '^');
            //p2.Draw();

            HorisontalLine upLine = new HorisontalLine(0,78,0,'+');
            HorisontalLine downLine = new HorisontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0,24,0,'+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(10,10,'*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Draw();
            Console.ReadLine();
        }

        
    }
}
