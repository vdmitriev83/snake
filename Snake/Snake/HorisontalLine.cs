using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class HorisontalLine
    {
        private List<Point> pList;

        public HorisontalLine (int xLeft,int xRight,int y, char sym)
        {
            pList=new List<Point>();
            for(int x = xLeft; x<=xRight; x++)
            {
                Point p = new Point(x,y,sym); 
                pList.Add(p);
            }
            /*Point p1 = new Point(4,4,'*');
            Point p2 = new Point(5,4, '*');
            Point p3 = new Point(6,4, '*');
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
             */ 

        }

        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }
    }
}
