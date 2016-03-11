using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Walls
    {
        private List<Figure> wallList;

        public Walls(int width, int height)
        {
            wallList = new List<Figure>();

            HorisontalLine upLine = new HorisontalLine(0, width-2, 0, '+');
            HorisontalLine downLine = new HorisontalLine(0, width-2, height-1, '+');
            VerticalLine leftLine = new VerticalLine(0, height-1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, height-1, width-2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            return wallList.Any(wall => wall.IsHit(figure));
        }

        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            
            foreach (var wall in wallList)
            {
                wall.Draw();
            }

            Console.BackgroundColor = ConsoleColor.Black;
            
        }
    }
}
