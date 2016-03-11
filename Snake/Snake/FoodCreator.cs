using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class FoodCreator
    {
        private int mapWidth;
        private int mapHeight;
        private char symbol;

        Random random=new Random();
        public FoodCreator(int width, int height, char sym)
        {
            this.mapWidth = width;
            this.mapHeight = height;
            this.symbol = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x,y,symbol);
        }

        public Point CreateFood(Figure f)
        {
            Point p;
            int x,y;
            x = random.Next(2, mapWidth - 2);
            y = random.Next(2, mapHeight - 2);
            p = new Point(x, y, symbol);
            
            while(f.Consist(p))
            {
                x = random.Next(2, mapWidth - 2);
                y = random.Next(2, mapHeight - 2);
                p = new Point(x, y, symbol);
            }
            
            return p;
        }
    }
}
