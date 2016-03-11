﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class HorisontalLine:Figure
    {
        //private List<Point> pList;

        public HorisontalLine (int xLeft,int xRight,int y, char sym)
        {
            pList=new List<Point>();
            for(int x = xLeft; x<=xRight; x++)
            {
                Point p = new Point(x,y,sym); 
                pList.Add(p);
            }
        }

        /*
        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }
        */
    }
}
