using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }

        internal bool Consist(Point f)
        {
            if (pList == null)
            {
                return false;
            }
            else
            {
                if (pList.Any(p => p.IsHit(f)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        internal bool IsHit(Figure figure)
        {
            return pList.Any(p => figure.IsHit(p));
        }

        private bool IsHit(Point point)
        {
            return pList.Any(p => point.IsHit(p));
        }
    }
}
