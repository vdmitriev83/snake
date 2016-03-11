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

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction dir)
        {
            switch (dir)
            {
                case Direction.DOWN:
                {
                    y += offset;
                    break;
                }
                case Direction.LEFT:
                {
                    x -= offset;
                    break;
                }
                case Direction.RIGHT:
                {
                    x += offset;
                    break;
                }
                case Direction.UP:
                {
                    y -= offset;
                    break;
                }
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + "," + y + ", " + sym;
        }

        internal void Clear()
        {
            //throw new NotImplementedException();
            /*
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
            */
            sym = ' ';
            Draw();
        }
    }
}
