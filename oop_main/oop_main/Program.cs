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
            VertLine vline = new VertLine(2, 5, 7, '#');
            vline.Draw();

            HorizLine line = new HorizLine(1, 20, 4, '^');
                line.Draw();

           


            


            Console.Read();
        }

       

    }
}
