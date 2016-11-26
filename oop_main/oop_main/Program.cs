using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_main
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 3, 'Q');
            Point p2 = new Point(4, 4, 'Q');
            Point p3 = new Point(5, 5, 'Q');
            Point p4 = new Point(6, 5, 'Q');




            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);


            foreach (Point i in pList)
            {
                i.Draw();
            }
            Console.ReadLine();  


        }

       

    }
}
