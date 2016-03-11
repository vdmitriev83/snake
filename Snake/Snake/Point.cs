using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x ;
        public int y;
        public char sym;

        public Point(int x1, int y1, char symbol)
        {
            x = x1;
            y = y1;
            sym = symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
