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

            HorisontalLine line = new HorisontalLine(5,10,8,'+');
            line.Draw();


            Console.ReadLine();
        }

        
    }
}
