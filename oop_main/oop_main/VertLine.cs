using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_main
{
    class VertLine
    {

        List<Point> pList;
        public VertLine(int y1, int y2, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = y1; y <= y2; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
