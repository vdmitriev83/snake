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
            
            Point p = new Point( );
            p.x = 3;
            p.y = 5;
            p.sym = '&';
             
            p.Draw();

            Console.ReadLine();
        }

        
    }
}
